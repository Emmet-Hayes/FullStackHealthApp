import { useEffect, useState } from 'react';
import '../src/App.css';
import * as React from 'react';

interface Patient {
    name: string;
    email: string;
    phone: string;
    age: number;
    gender: string;
    address: string;
    city: string;
    region: string;
    postal: string;
    country: string;
    bloodType: string;
    allergies: string;
    medications: string;
    history: string;
}

function PatientsView() {
    const [patients, setPatients] = useState<Patient[]>();

    useEffect(() => {
        populatePatientData();
    }, []);


    const patientCards = patients === undefined
        ? <p><em>Loading patient data... Please refresh once the ASP.NET backend has started.</em></p>
        : patients.map(patient => (
            <div key={patient.name} className="patient-card">
                <div className="patient-section">
                    <div><strong>Name:</strong> {patient.name}</div>
                    <div><strong>Email:</strong> {patient.email}</div>
                    <div><strong>Phone:</strong> {patient.phone}</div>
                </div>
                <div className="patient-section">
                    <div><strong>Address:</strong> {patient.address}, {patient.city}, {patient.region}, {patient.postal}, {patient.country}</div>
                    <div><strong>Gender:</strong> {patient.gender} <strong>Age:</strong> {patient.age}</div>
                    <div><strong>Blood Type:</strong> {patient.bloodType}</div>
                </div>
                <div className="patient-section">
                    <div><strong>Allergies:</strong> {patient.allergies}</div>
                    <div><strong>Medications:</strong> {patient.medications}</div>
                    <div><strong>History:</strong> {patient.history}</div>
                </div>
            </div>
        ));

    return (
        <div>
            <h1 id="tabelLabel">Patient Data</h1>
            <p>This component fetches patient data from the server.</p>
            <div className="patient-container">{patientCards}</div>
        </div>
    );

    async function populatePatientData() {
        try {
            const response = await fetch('patients');
            if (!response.ok) {
                throw new Error(`Error: ${response.status} - ${response.statusText}`);
            }
            const data = await response.json();
            setPatients(data);
        } catch (error) {
            console.error("Failed to fetch patient data:", error);
            // Handle the error appropriately in your UI
        }
    }
}

export default PatientsView;
