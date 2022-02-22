import { ChangeEvent, useState } from 'react';
import { Form, Button, ButtonGroup } from 'react-bootstrap';

import Activity from '../../../app/models/activity';

interface Props {
  activity: Activity | undefined;
  closeForm: () => void;
  createOrEdit: (activity: Activity) => void;
}

const ActivityForm = ({
  activity: selectedActivity,
  closeForm,
  createOrEdit,
}: Props) => {
  const initState = selectedActivity ?? {
    id: '',
    title: '',
    description: '',
    category: '',
    date: '',
    city: '',
    venue: '',
  };

  const [activity, setActivity] = useState(initState);

  const inputChangeHandler = (event: ChangeEvent<HTMLInputElement>) => {
    //console.log(event.target.value);

    const { name, value } = event.target;

    setActivity({
      ...activity,
      [name]: value,
    });
  };

  const submitHandler = (event: ChangeEvent<HTMLFormElement>) => {
    event.preventDefault();
    console.log(activity);
    createOrEdit(activity);
  };

  return (
    <Form className="mt-5" autoComplete="off" onSubmit={submitHandler}>
      <Form.Group className="mb-3" controlId="formTitle">
        <Form.Label>Title</Form.Label>
        <Form.Control
          value={activity.title}
          type="text"
          name="title"
          onChange={inputChangeHandler}
        />
      </Form.Group>

      <Form.Group className="mb-3">
        <Form.Label>Description</Form.Label>
        <Form.Control
          as="textarea"
          value={activity.description}
          type="area"
          name="description"
          onChange={inputChangeHandler}
        />
      </Form.Group>

      <Form.Group className="mb-3">
        <Form.Label>Category</Form.Label>
        <Form.Control
          type="text"
          placeholder="category"
          name="category"
          value={activity.category}
          onChange={inputChangeHandler}
        />
      </Form.Group>

      <Form.Group className="mb-3">
        <Form.Label>Date</Form.Label>
        <Form.Control
          type="date"
          placeholder="Date"
          name="date"
          value={activity.date}
          onChange={inputChangeHandler}
        />
      </Form.Group>

      <Form.Group className="mb-3">
        <Form.Label>City</Form.Label>
        <Form.Control
          type="text"
          placeholder="City"
          name="city"
          value={activity.city}
          onChange={inputChangeHandler}
        />
      </Form.Group>

      <Form.Group className="mb-3">
        <Form.Label>Venue</Form.Label>
        <Form.Control
          type="text"
          placeholder="Venue"
          name="venue"
          value={activity.venue}
          onChange={inputChangeHandler}
        />
      </Form.Group>

      <ButtonGroup>
        <Button type="submit" size="lg" className="ms-5" variant="primary">
          Submit
        </Button>
        <Button size="lg" className="ms-5" variant="danger" onClick={closeForm}>
          Cancel
        </Button>
      </ButtonGroup>
    </Form>
  );
};

export default ActivityForm;
