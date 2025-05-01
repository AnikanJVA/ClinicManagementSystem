
CREATE TABLE users
(
	userID bigint PRIMARY KEY,
	username varchar(255) NOT NULL,
	password varchar(255) NOT NULL,
	accType varchar(12) NOT NULL,
	status varchar(8) DEFAULT = 'ACTIVE',
	
	CONSTRAINT check_accType CHECK (accType = 'doctor' OR acctype = 'receptionist' OR accType = 'admin'),
	CONSTRAINT check_status CHECK (status = 'active' OR status = 'inactive')
)


