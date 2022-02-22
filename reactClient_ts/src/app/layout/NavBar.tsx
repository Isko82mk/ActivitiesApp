import { Navbar, Container, Nav, Button } from 'react-bootstrap';

interface Props {
  openForm: () => void;
}

const NavBar = ({ openForm }: Props) => {
  return (
    <Navbar bg="dark" variant="dark" className="mb-4">
      <Container>
        <Navbar.Brand href="#home">
          <img
            src="/images/logo.png"
            width="50"
            height="40"
            className="d-inline-block align-top"
            alt="ReactiviteisLogo"
          />
          <span className="align-middle" style={{ marginLeft: '10px' }}>
            Reactivities
          </span>
        </Navbar.Brand>
        <Nav className="me-auto">
          <Nav.Link href="#home">Activities</Nav.Link>
          <Button className="mx-5" variant="success" onClick={openForm}>
            Create Activity
          </Button>
        </Nav>
      </Container>
    </Navbar>
  );
};

export default NavBar;
