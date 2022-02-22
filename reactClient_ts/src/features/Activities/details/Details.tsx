import {
  Card,
  Button,
  ButtonGroup,
  ListGroup,
  ListGroupItem,
} from 'react-bootstrap';
import Activity from '../../../app/models/activity';

interface Props {
  activity: Activity;
  cancelActivity: () => void;
  openForm: () => void;
}
const Details = ({ activity, cancelActivity, openForm }: Props) => {
  return (
    <Card style={{ width: '22rem' }}>
      <Card.Img
        variant="top"
        src={`/Images/categoryImages/${activity.category}.jpg`}
      />
      <Card.Body>
        <ListGroup className="list-group-flush">
          <Card.Title>{activity.title}</Card.Title>
          <ListGroupItem>Date : {activity.date}</ListGroupItem>
          <ListGroupItem>Description : {activity.description}</ListGroupItem>
          <ListGroupItem>City : {activity.city}</ListGroupItem>
          <ListGroupItem>Venue : {activity.venue}</ListGroupItem>
          <ListGroupItem>Category : {activity.category}</ListGroupItem>
          <ListGroupItem></ListGroupItem>
        </ListGroup>

        <ButtonGroup>
          <Button
            size="lg"
            className="ms-5"
            variant="primary"
            onClick={openForm}
          >
            Edit
          </Button>
          <Button
            size="lg"
            className="ms-5"
            variant="danger"
            onClick={cancelActivity}
          >
            Cancel
          </Button>
        </ButtonGroup>
      </Card.Body>
    </Card>
  );
};
export default Details;
