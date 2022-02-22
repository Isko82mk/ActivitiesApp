import { Card, Button, ButtonGroup } from 'react-bootstrap';
import Activity from '../../../app/models/activity';

interface Props {
  activities: Activity[];

  selectActivityHandler: (id: string) => void;
  deleteActivity: (id: string) => void;
}

const ActivityList = ({
  activities,
  selectActivityHandler,
  deleteActivity,
}: Props) => {
  return (
    <div className="d-flex  align-content-start justify-content-start flex-wrap  gap-2">
      {activities.map((x) => {
        return (
          <Card key={x.id} style={{ width: '18rem' }}>
            <Card.Body>
              <Card.Title>{x.title}</Card.Title>
              <Card.Text>{x.description}</Card.Text>
              <ButtonGroup>
                <Button
                  className="me-3"
                  variant="primary"
                  onClick={() => {
                    selectActivityHandler(x.id);
                  }}
                >
                  View
                </Button>
                <Button
                  className="ms-5"
                  variant="danger"
                  onClick={() => {
                    deleteActivity(x.id);
                  }}
                >
                  Delete
                </Button>
              </ButtonGroup>
            </Card.Body>
          </Card>
        );
      })}
    </div>
  );
};

export default ActivityList;
