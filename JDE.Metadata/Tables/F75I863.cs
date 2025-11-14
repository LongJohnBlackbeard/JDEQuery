using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I863 - .
/// </summary>
public class F75I863 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDI75INVNO.
        /// </summary>
        public const string EDI75INVNO = "EDI75INVNO";

        /// <summary>
        /// EDINVDT.
        /// </summary>
        public const string EDINVDT = "EDINVDT";

        /// <summary>
        /// EDI75GSTNO.
        /// </summary>
        public const string EDI75GSTNO = "EDI75GSTNO";

        /// <summary>
        /// EDI75GSTNP.
        /// </summary>
        public const string EDI75GSTNP = "EDI75GSTNP";

        /// <summary>
        /// EDI75IRNNO.
        /// </summary>
        public const string EDI75IRNNO = "EDI75IRNNO";

        /// <summary>
        /// EDKCO.
        /// </summary>
        public const string EDKCO = "EDKCO";

        /// <summary>
        /// EDDCT.
        /// </summary>
        public const string EDDCT = "EDDCT";

        /// <summary>
        /// EDDOC.
        /// </summary>
        public const string EDDOC = "EDDOC";

        /// <summary>
        /// EDI75ACKDT.
        /// </summary>
        public const string EDI75ACKDT = "EDI75ACKDT";

        /// <summary>
        /// EDI75QRCD.
        /// </summary>
        public const string EDI75QRCD = "EDI75QRCD";

        /// <summary>
        /// EDI75ACKNO.
        /// </summary>
        public const string EDI75ACKNO = "EDI75ACKNO";

        /// <summary>
        /// EDI75STS.
        /// </summary>
        public const string EDI75STS = "EDI75STS";

        /// <summary>
        /// EDI75MSG1.
        /// </summary>
        public const string EDI75MSG1 = "EDI75MSG1";

        /// <summary>
        /// EDI75MSG2.
        /// </summary>
        public const string EDI75MSG2 = "EDI75MSG2";

        /// <summary>
        /// EDI75MSG3.
        /// </summary>
        public const string EDI75MSG3 = "EDI75MSG3";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";

        /// <summary>
        /// EDYFUTDT.
        /// </summary>
        public const string EDYFUTDT = "EDYFUTDT";

        /// <summary>
        /// EDFFU4.
        /// </summary>
        public const string EDFFU4 = "EDFFU4";

        /// <summary>
        /// EDFUT3.
        /// </summary>
        public const string EDFUT3 = "EDFUT3";

        /// <summary>
        /// EDX2.
        /// </summary>
        public const string EDX2 = "EDX2";

        /// <summary>
        /// EDFUTCH1.
        /// </summary>
        public const string EDFUTCH1 = "EDFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I863";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDI75INVNO", "EDI75INVNO", JdeDataType.String, 50, true, true),
        new JdeField("EDINVDT", "EDINVDT", JdeDataType.Numeric, null, true, true),
        new JdeField("EDI75GSTNO", "EDI75GSTNO", JdeDataType.String, 50, true, true),
        new JdeField("EDI75GSTNP", "EDI75GSTNP", JdeDataType.String, 50, true, true),
        new JdeField("EDI75IRNNO", "EDI75IRNNO", JdeDataType.String, 128, true, true),
        new JdeField("EDKCO", "EDKCO", JdeDataType.String, 10),
        new JdeField("EDDCT", "EDDCT", JdeDataType.String, 4),
        new JdeField("EDDOC", "EDDOC", JdeDataType.Numeric),
        new JdeField("EDI75ACKDT", "EDI75ACKDT", JdeDataType.Date),
        new JdeField("EDI75QRCD", "EDI75QRCD", JdeDataType.String, 2400),
        new JdeField("EDI75ACKNO", "EDI75ACKNO", JdeDataType.String, 80),
        new JdeField("EDI75STS", "EDI75STS", JdeDataType.String, 6),
        new JdeField("EDI75MSG1", "EDI75MSG1", JdeDataType.String, 2048),
        new JdeField("EDI75MSG2", "EDI75MSG2", JdeDataType.String, 2048),
        new JdeField("EDI75MSG3", "EDI75MSG3", JdeDataType.String, 2048),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric),
        new JdeField("EDYFUTDT", "EDYFUTDT", JdeDataType.Numeric),
        new JdeField("EDFFU4", "EDFFU4", JdeDataType.Numeric),
        new JdeField("EDFUT3", "EDFUT3", JdeDataType.String, 60),
        new JdeField("EDX2", "EDX2", JdeDataType.String, 2),
        new JdeField("EDFUTCH1", "EDFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I863_0", "Primary Key on EDI75INVNO, EDINVDT, EDI75GSTNO, EDI75GSTNP, EDI75IRNNO", new[] { "EDI75INVNO", "EDINVDT", "EDI75GSTNO", "EDI75GSTNP", "EDI75IRNNO" }, isUnique: true, isPrimaryKey: true)
    };
}
