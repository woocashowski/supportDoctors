import openpyxl

class Patient:
    def __init__(id, password, k1, k2, k3, k4,
                 k5, k6, k7, k8, outcome, prediction):
        self.id = id
        self.password = password
        self.k1 = k1
        self.k2 = k2
        self.k3 = k3
        self.k4 = k4
        self.k5 = k5
        self.k6 = k6
        self.k7 = k7
        self.k8 = k8
        self.outcome = outcome
        self.prediction = prediction

    def read_patient(id):
        pass



