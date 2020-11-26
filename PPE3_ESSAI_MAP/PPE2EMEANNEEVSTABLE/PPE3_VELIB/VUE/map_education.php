<?php 

	class education	{
		private $id;
		private $name;
		private $address;	
		private $lat;
		private $lng;
        private $latB;
		private $lngB;
		private $conn;
		private $tableName = "borne";
        private $tableName2 = "vehicule";

		function setId($id) { $this->id = $id; }
		function getId() { return $this->id; }
		function setName($name) { $this->name = $name; }
		function getName() { return $this->name; }
		function setAddress($address) { $this->address = $address; }
		function getAddress() { return $this->address; }
		
		function setLat($lat) { $this->lat = $lat; }
		function getLat() { return $this->lat; }
		function setLng($lng) { $this->lng = $lng; }
		function getLng() { return $this->lng; }
        // borne
        function setLatB($latB) { $this->latB = $latB; }
		function getLatB() { return $this->latB; }
		function setLngB($lngB) { $this->lngB = $lngB; }
		function getLngB() { return $this->lngB; }

	/*	public function __construct() {
			require_once('db/DbConnect.php');
			$conn = new DbConnect;
			$this->conn = $conn->connect();
		}*/

		public function getCollegesBlankLatLng() 
        {
            if($this->idc)
                {
                
                    $req = "SELECT * FROM $this->tableName2 WHERE latitudeV IS NULL AND longitudeV IS NULL";
                    $result = $this->idc->query($req);
                    Connexion::disconnect();
                    return $result; 
                }
			
		}

		public function getAllColleges() {
			$req = "SELECT * FROM $this->tableName2";
			$stmt = $this->conn->prepare($req);
			$stmt->execute();
			return $stmt->fetchAll(PDO::FETCH_ASSOC);
		}

		public function updateCollegesWithLatLng() {
			$req = "UPDATE $this->tableName2 SET latitudeV = :lat, longitudeV = :lng WHERE id = :id";
            $result = $this->idc->query($req);
			$result->bindParam(':lat', $this->lat);
			$result->bindParam(':lng', $this->lng);
			$result->bindParam(':id', $this->id);

			if($stmt->execute()) {
				return true;
			} else {
				return false;
			}
            // test Borne 
        }
        
        public function getBorneBlankLatLng() 
        {
            if($this->idc)
                {
                    $req = "SELECT * FROM borne WHERE latitudeB IS NULL AND longitudeB IS NULL";
                    $result = $this->idc->query($req);
                    Connexion::disconnect();
                    return $result; 
                }
		}

		public function getAllBorne()
        {
            if($this->idc)
                {
                    $req = "SELECT * FROM borne";
                    $result = $this->idc->query($req);
                    Connexion::disconnect();
                    return $result; 
                }
		}

		public function updateBorneWithLatLng() {
			$req = "UPDATE borne SET latitudeB = :latB, longitudeB = :lngB WHERE id = :id";
            $result = $this->idc->query($req);
			$result->bindParam(':latB', $this->lat);
			$result->bindParam(':lngB', $this->lng);
			$result->bindParam(':id', $this->id);

			if($result->execute()) {
				return true;
			} else {
				return false;
			}
            
		}
	}
    

?>