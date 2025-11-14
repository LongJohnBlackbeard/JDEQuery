using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F086410 - .
/// </summary>
public class F086410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRESTB.
        /// </summary>
        public const string CRESTB = "CRESTB";

        /// <summary>
        /// CRCALYEAR.
        /// </summary>
        public const string CRCALYEAR = "CRCALYEAR";

        /// <summary>
        /// CRRPTTYPE.
        /// </summary>
        public const string CRRPTTYPE = "CRRPTTYPE";

        /// <summary>
        /// CRCHGRSN.
        /// </summary>
        public const string CRCHGRSN = "CRCHGRSN";

        /// <summary>
        /// CRCHGSEQ.
        /// </summary>
        public const string CRCHGSEQ = "CRCHGSEQ";

        /// <summary>
        /// CROSHAUDT1.
        /// </summary>
        public const string CROSHAUDT1 = "CROSHAUDT1";

        /// <summary>
        /// CROSHAUSTR1.
        /// </summary>
        public const string CROSHAUSTR1 = "CROSHAUSTR1";

        /// <summary>
        /// CROSHAUSTR2.
        /// </summary>
        public const string CROSHAUSTR2 = "CROSHAUSTR2";

        /// <summary>
        /// CROSHAUC1.
        /// </summary>
        public const string CROSHAUC1 = "CROSHAUC1";

        /// <summary>
        /// CROSHAUMN1.
        /// </summary>
        public const string CROSHAUMN1 = "CROSHAUMN1";

        /// <summary>
        /// CROSHADT1.
        /// </summary>
        public const string CROSHADT1 = "CROSHADT1";

        /// <summary>
        /// CROSHASTR1.
        /// </summary>
        public const string CROSHASTR1 = "CROSHASTR1";

        /// <summary>
        /// CROSHASTR2.
        /// </summary>
        public const string CROSHASTR2 = "CROSHASTR2";

        /// <summary>
        /// CROSHAMN1.
        /// </summary>
        public const string CROSHAMN1 = "CROSHAMN1";

        /// <summary>
        /// CROSHAC1.
        /// </summary>
        public const string CROSHAC1 = "CROSHAC1";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";
    }

    /// <inheritdoc />
    public override string TableName => "F086410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRESTB", "CRESTB", JdeDataType.Numeric, null, true, true),
        new JdeField("CRCALYEAR", "CRCALYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("CRRPTTYPE", "CRRPTTYPE", JdeDataType.String, 8, true, true),
        new JdeField("CRCHGRSN", "CRCHGRSN", JdeDataType.String, 200),
        new JdeField("CRCHGSEQ", "CRCHGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CROSHAUDT1", "CROSHAUDT1", JdeDataType.Numeric),
        new JdeField("CROSHAUSTR1", "CROSHAUSTR1", JdeDataType.String, 60),
        new JdeField("CROSHAUSTR2", "CROSHAUSTR2", JdeDataType.String, 60),
        new JdeField("CROSHAUC1", "CROSHAUC1", JdeDataType.String, 2),
        new JdeField("CROSHAUMN1", "CROSHAUMN1", JdeDataType.Numeric),
        new JdeField("CROSHADT1", "CROSHADT1", JdeDataType.Numeric),
        new JdeField("CROSHASTR1", "CROSHASTR1", JdeDataType.String, 60),
        new JdeField("CROSHASTR2", "CROSHASTR2", JdeDataType.String, 60),
        new JdeField("CROSHAMN1", "CROSHAMN1", JdeDataType.Numeric),
        new JdeField("CROSHAC1", "CROSHAC1", JdeDataType.String, 2),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F086410_0", "Primary Key on CRESTB, CRCALYEAR, CRRPTTYPE, CRCHGSEQ", new[] { "CRESTB", "CRCALYEAR", "CRRPTTYPE", "CRCHGSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
