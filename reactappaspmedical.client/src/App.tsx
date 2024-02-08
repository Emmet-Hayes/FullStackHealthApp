import './App.css';
import AppointmentsView from '../Views/AppointmentsView.tsx';
import PatientsView from '../Views/PatientsView.tsx';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

function App() {
    return (
        <Router>
            <div>
                <nav>
                    <ul>
                        <li>
                            <Link to="/appointments">Appointments</Link>
                        </li>
                        <li>
                            <Link to="/patients">Patients</Link>
                        </li>
                    </ul>
                </nav>

                <Routes>
                    <Route path="/appointments" element={<AppointmentsView />} />
                    <Route path="/patients" element={<PatientsView />} />
                    <Route path="/" element={<PatientsView />} /> {/* Default view */}
                </Routes>
            </div>
        </Router>
    );
}

export default App;
