import { Container, Row, Col } from 'react-bootstrap';
import Activity from '../../../app/models/activity';
import ActivityList from '../Dashboard/ActivityList';
import Details from '../details/Details';
import ActivityForm from '../form/ActivityForm';

interface Props {
  activities: Activity[];
  selectedActivity: Activity | undefined;
  selectActivityHandeler: (id: string) => void;
  cancelSelectedActivity: () => void;
  editMode: boolean;
  openForm: () => void;
  cancelForm: () => void;
  createOrEdit: (activity: Activity) => void;
  deleteActivity: (id: string) => void;
}

const ActivityDashboard = ({
  activities,
  selectedActivity,
  selectActivityHandeler,
  cancelSelectedActivity,
  editMode,
  openForm,
  cancelForm,
  createOrEdit,
  deleteActivity,
}: Props) => {
  return (
    <Container>
      <Row>
        <Col sm={6} xs={4}>
          <ActivityList
            activities={activities}
            selectActivityHandler={selectActivityHandeler}
            deleteActivity={deleteActivity}
          />
        </Col>

        <Col md={4} xs={6}>
          {selectedActivity && !editMode && (
            <Details
              activity={selectedActivity}
              cancelActivity={cancelSelectedActivity}
              openForm={openForm}
            />
          )}
          {editMode && (
            <ActivityForm
              closeForm={cancelForm}
              activity={selectedActivity}
              createOrEdit={createOrEdit}
            />
          )}
        </Col>
      </Row>
    </Container>
  );
};
export default ActivityDashboard;
