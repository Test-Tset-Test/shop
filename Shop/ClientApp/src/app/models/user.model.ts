interface UserDataModel {
  account: {
    activated: number;
    login: string;
    email: string;
    created_at: number;
    updated_at: number;
    vk_uid: number;
  };
  gameAccount: {
    activated: string;
    membership: string;
    membership_expires: string;
    toll: string;
    fp: string;
  };
}

interface UserAuthModel {
  password: string;
  userName: string;
}

interface UserAuthTokenModel {
  token: string;
}

interface UserAuthFormModel {
  login: string;
  password: string;
}
