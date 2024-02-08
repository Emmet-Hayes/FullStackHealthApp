import { useEffect, useState } from 'react';
import '../src/App.css';
import * as React from 'react';

interface Appointment {
    patient: string;
    doctor: string;
    room: string;
    time: string;
    next: string;
}

function AppointmentsView() {
    const [appointments, setAppointments] = useState<Appointment[]>();

    useEffect(() => {
        populateAppointmentData();
    }, []);

    const appointmentCards = appointments === undefined
        ? <p><em>Loading appointment data... Please refresh once the ASP.NET backend has started.</em></p>
        : appointments.map(appointment => (
            <div key={appointment.patient} className="appointment-card">
                <div className="appointment-section">
                    <div><strong>Patient:</strong> {appointment.patient}</div>
                    <div><strong>Doctor:</strong> {appointment.doctor}</div>
                    <div><strong>Room:</strong> {appointment.room}</div>
                </div>
                <div className="appointment-section">
                    <div><strong>Time:</strong> {appointment.time}</div>
                    <div><strong>Next:</strong> {appointment.next}</div>
                </div>
            </div>
        ));

    return (
        <div>
            <h1 id="tabelLabel">Appointment Data</h1>
            <p>This component fetches appointment data from the server.</p>
            <div className="appointment-container">{appointmentCards}</div>
        </div>
    );

    async function populateAppointmentData() {
        try {
            const response = await fetch('appointments');
            if (!response.ok) {
                throw new Error(`Error: ${response.status} - ${response.statusText}`);
            }
            const data = await response.json();
            setAppointments(data);
        } catch (error) {
            console.error("Failed to fetch patient data:", error);
            // Handle the error appropriately in your UI
        }
    }
}

export default AppointmentsView;