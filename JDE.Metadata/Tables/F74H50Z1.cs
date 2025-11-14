using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H50Z1 - .
/// </summary>
public class F74H50Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RFEDUS.
        /// </summary>
        public const string RFEDUS = "RFEDUS";

        /// <summary>
        /// RFEDBT.
        /// </summary>
        public const string RFEDBT = "RFEDBT";

        /// <summary>
        /// RFEDTN.
        /// </summary>
        public const string RFEDTN = "RFEDTN";

        /// <summary>
        /// RFEDLN.
        /// </summary>
        public const string RFEDLN = "RFEDLN";

        /// <summary>
        /// RFKCO.
        /// </summary>
        public const string RFKCO = "RFKCO";

        /// <summary>
        /// RFK74FLEN.
        /// </summary>
        public const string RFK74FLEN = "RFK74FLEN";

        /// <summary>
        /// RFH74TCID.
        /// </summary>
        public const string RFH74TCID = "RFH74TCID";

        /// <summary>
        /// RFH74TRUTC.
        /// </summary>
        public const string RFH74TRUTC = "RFH74TRUTC";

        /// <summary>
        /// RFH74PRFLG.
        /// </summary>
        public const string RFH74PRFLG = "RFH74PRFLG";

        /// <summary>
        /// RFH74VLRCD.
        /// </summary>
        public const string RFH74VLRCD = "RFH74VLRCD";

        /// <summary>
        /// RFH74MSSG.
        /// </summary>
        public const string RFH74MSSG = "RFH74MSSG";

        /// <summary>
        /// RFICUT.
        /// </summary>
        public const string RFICUT = "RFICUT";

        /// <summary>
        /// RFDICJ.
        /// </summary>
        public const string RFDICJ = "RFDICJ";

        /// <summary>
        /// RFUSER.
        /// </summary>
        public const string RFUSER = "RFUSER";

        /// <summary>
        /// RFPID.
        /// </summary>
        public const string RFPID = "RFPID";

        /// <summary>
        /// RFJOBN.
        /// </summary>
        public const string RFJOBN = "RFJOBN";

        /// <summary>
        /// RFUPMJ.
        /// </summary>
        public const string RFUPMJ = "RFUPMJ";

        /// <summary>
        /// RFUPMT.
        /// </summary>
        public const string RFUPMT = "RFUPMT";

        /// <summary>
        /// RFH74FUTDT.
        /// </summary>
        public const string RFH74FUTDT = "RFH74FUTDT";

        /// <summary>
        /// RFH74FUTNM.
        /// </summary>
        public const string RFH74FUTNM = "RFH74FUTNM";

        /// <summary>
        /// RFFUT6.
        /// </summary>
        public const string RFFUT6 = "RFFUT6";

        /// <summary>
        /// RFX2.
        /// </summary>
        public const string RFX2 = "RFX2";

        /// <summary>
        /// RFH74FUTCH.
        /// </summary>
        public const string RFH74FUTCH = "RFH74FUTCH";
    }

    /// <inheritdoc />
    public override string TableName => "F74H50Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RFEDUS", "RFEDUS", JdeDataType.String, 20, true, true),
        new JdeField("RFEDBT", "RFEDBT", JdeDataType.String, 30, true, true),
        new JdeField("RFEDTN", "RFEDTN", JdeDataType.String, 44, true, true),
        new JdeField("RFEDLN", "RFEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RFKCO", "RFKCO", JdeDataType.String, 10),
        new JdeField("RFK74FLEN", "RFK74FLEN", JdeDataType.String, 50),
        new JdeField("RFH74TCID", "RFH74TCID", JdeDataType.String, 60),
        new JdeField("RFH74TRUTC", "RFH74TRUTC", JdeDataType.Date),
        new JdeField("RFH74PRFLG", "RFH74PRFLG", JdeDataType.String, 2),
        new JdeField("RFH74VLRCD", "RFH74VLRCD", JdeDataType.String, 100),
        new JdeField("RFH74MSSG", "RFH74MSSG", JdeDataType.String, 2048),
        new JdeField("RFICUT", "RFICUT", JdeDataType.String, 4),
        new JdeField("RFDICJ", "RFDICJ", JdeDataType.Numeric),
        new JdeField("RFUSER", "RFUSER", JdeDataType.String, 20),
        new JdeField("RFPID", "RFPID", JdeDataType.String, 20),
        new JdeField("RFJOBN", "RFJOBN", JdeDataType.String, 20),
        new JdeField("RFUPMJ", "RFUPMJ", JdeDataType.Numeric),
        new JdeField("RFUPMT", "RFUPMT", JdeDataType.Numeric),
        new JdeField("RFH74FUTDT", "RFH74FUTDT", JdeDataType.Numeric),
        new JdeField("RFH74FUTNM", "RFH74FUTNM", JdeDataType.Numeric),
        new JdeField("RFFUT6", "RFFUT6", JdeDataType.String, 60),
        new JdeField("RFX2", "RFX2", JdeDataType.String, 2),
        new JdeField("RFH74FUTCH", "RFH74FUTCH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H50Z1_0", "Primary Key on RFEDUS, RFEDBT, RFEDTN, RFEDLN", new[] { "RFEDUS", "RFEDBT", "RFEDTN", "RFEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
