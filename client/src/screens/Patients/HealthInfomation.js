import React, { useState } from "react";
import { sortsDatas } from "../../components/Datas";
import {
  Button,
  Input,
  Select,
  Switchi,
  Textarea,
} from "../../components/Form";
import { BiChevronDown } from "react-icons/bi";
import { HiOutlineCheckCircle } from "react-icons/hi";
import { toast } from "react-hot-toast";

// Health Information
// allergies
// habits
// Medical History

function HealthInfomation() {
  const questions = [
    { id: 2, text: "A jeni nën trajtimin e një mjeku?" },
    {
      id: 3,
      text: "A jeni diagnostifikuar me ndonjë sëmundje? A keni kryer ndonjë ndërhyrje kirurgjikale?",
    },
    {
      id: 4,
      text: "A keni patur ndonjë sëmundje të zemrës(anomali, sëmundje reumatizmale, atak, tension të lartë zhurmë në zemër, dhimbje kraharore)?",
    },
  ];

  const [answers, setAnswers] = useState(
    questions.reduce((acc, question) => {
      acc[question.id] = false;
      return acc;
    }, {})
  );

  const handleToggle = (id) => {
    setAnswers((prevAnswers) => ({
      ...prevAnswers,
      [id]: !prevAnswers[id],
    }));
  };

  const [bloodType, setBloodType] = React.useState(
    sortsDatas.bloodTypeFilter[0]
  );
  return (
    <div className="flex-colo gap-4">
      {/* uploader */}
      <div className="flex gap-3 flex-col w-full col-span-6">
        {/* select  */}
        <div className="flex w-full flex-col gap-3">
          <p className="text-black text-sm">Anamnze Mjeksore</p>
          {/* switch */}
          <div>
            {questions.map((question) => (
              <div
                key={question.id}
                className="flex items-center justify-between gap-2 w-full"
              >
                <div className="flex items-center gap-2">
                  {question.text}
                  <p
                    className={`text-sm ${
                      answers[question.id] ? "text-subMain" : "text-textGray"
                    }`}
                  >
                    {answers[question.id] ? "PO" : "JO"}
                  </p>
                </div>
                <Switchi
                  label="Status"
                  checked={answers[question.id]}
                  onChange={() => handleToggle(question.id)}
                  className="fixed-size"
                />
              </div>
            ))}
          </div>
        </div>
        {/* weight */}
        {/* <Input label="Weight" color={true} type="text" placeholder={"60kg"} /> */}
        {/* height */}
        {/* <Input label="Height" color={true} type="text" placeholder={"5.5ft"} /> */}
        {/* allergies */}
        {/* <Textarea
          label="Allergies"
          color={true}
          rows={3}
          placeholder={"beans, nuts, etc"}
        /> */}
        {/* habits */}
        {/* <Textarea
          label="Habits"
          color={true}
          rows={3}
          placeholder={"smoking, drinking, etc"}
        /> */}
        {/* Medical History */}
        {/* <Textarea
          label="Medical History"
          color={true}
          rows={3}
          placeholder={"diabetes,  malaria, glaucoma, etc"}
        /> */}
        {/* submit */}
        <Button
          label={"Save Changes"}
          Icon={HiOutlineCheckCircle}
          onClick={() => {
            toast.error("This feature is not available yet");
          }}
        />
      </div>
    </div>
  );
}

export default HealthInfomation;
