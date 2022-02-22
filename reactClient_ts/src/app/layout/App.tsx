import { useEffect, useState } from 'react';
import { Container } from 'react-bootstrap';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/Activities/Dashboard/ActivityDashboard';
import Activity from '../models/activity';
import agent from '../api/agent';

import { v4 as uuid } from 'uuid';

function App() {
  //const getAll = 'http://localhost:5000/api/activity/getall';

  const [data, setData] = useState<Activity[]>([]);

  const [selectedActivity, setSelectedActivity] = useState<
    Activity | undefined
  >(undefined);

  const [editMode, setEditMode] = useState(false);

  useEffect(() => {
    agent.Activities.allActivities().then((res) => {
      console.log(res);
      const allActivities = res;
      setData(allActivities);
    });
  }, []);

  const selectedActivityHandler = (id: string) => {
    setSelectedActivity(data.find((x) => x.id === id));
  };
  const cancelActivityHandler = () => {
    setSelectedActivity(undefined);
  };

  const editFormHandler = () => {
    setEditMode(true);
  };

  const cancelFormHandler = () => {
    setEditMode(false);
  };

  const createActivityHandler = (activity: Activity) => {
    activity.id
      ? setData([...data.filter((x) => x.id !== activity.id), activity])
      : setData([...data, { ...activity, id: uuid() }]);
    setEditMode(false);
    setSelectedActivity(activity);
  };

  const deleteActivityHandler = (id: string) => {
    setData([...data.filter((x) => x.id !== id)]);
  };
  return (
    <>
      <NavBar openForm={editFormHandler} />
      <Container className="mt-5">
        <ActivityDashboard
          activities={data}
          selectedActivity={selectedActivity}
          selectActivityHandeler={selectedActivityHandler}
          cancelSelectedActivity={cancelActivityHandler}
          editMode={editMode}
          openForm={editFormHandler}
          cancelForm={cancelFormHandler}
          createOrEdit={createActivityHandler}
          deleteActivity={deleteActivityHandler}
        />
      </Container>
    </>
  );
}

export default App;
