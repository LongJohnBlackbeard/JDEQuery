using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF170 - .
/// </summary>
public class F90CF170 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNSCRPTID.
        /// </summary>
        public const string TNSCRPTID = "TNSCRPTID";

        /// <summary>
        /// TNPATHID.
        /// </summary>
        public const string TNPATHID = "TNPATHID";

        /// <summary>
        /// TNTGSETID.
        /// </summary>
        public const string TNTGSETID = "TNTGSETID";

        /// <summary>
        /// TNEFFDT.
        /// </summary>
        public const string TNEFFDT = "TNEFFDT";

        /// <summary>
        /// TNPARPTHID.
        /// </summary>
        public const string TNPARPTHID = "TNPARPTHID";

        /// <summary>
        /// TNANYNDFG.
        /// </summary>
        public const string TNANYNDFG = "TNANYNDFG";

        /// <summary>
        /// TNQSTGRPID.
        /// </summary>
        public const string TNQSTGRPID = "TNQSTGRPID";

        /// <summary>
        /// TNQUSTID.
        /// </summary>
        public const string TNQUSTID = "TNQUSTID";

        /// <summary>
        /// TNANSWID.
        /// </summary>
        public const string TNANSWID = "TNANSWID";

        /// <summary>
        /// TNANSETID.
        /// </summary>
        public const string TNANSETID = "TNANSETID";

        /// <summary>
        /// TNRULSTID.
        /// </summary>
        public const string TNRULSTID = "TNRULSTID";

        /// <summary>
        /// TNRULITID.
        /// </summary>
        public const string TNRULITID = "TNRULITID";

        /// <summary>
        /// TNVARLID.
        /// </summary>
        public const string TNVARLID = "TNVARLID";

        /// <summary>
        /// TNSUBSCRID.
        /// </summary>
        public const string TNSUBSCRID = "TNSUBSCRID";

        /// <summary>
        /// TNSEQNBR.
        /// </summary>
        public const string TNSEQNBR = "TNSEQNBR";

        /// <summary>
        /// TNUSER.
        /// </summary>
        public const string TNUSER = "TNUSER";

        /// <summary>
        /// TNJOBN.
        /// </summary>
        public const string TNJOBN = "TNJOBN";

        /// <summary>
        /// TNMKEY.
        /// </summary>
        public const string TNMKEY = "TNMKEY";

        /// <summary>
        /// TNUDTTM.
        /// </summary>
        public const string TNUDTTM = "TNUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF170";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNSCRPTID", "TNSCRPTID", JdeDataType.Numeric, null, true, true),
        new JdeField("TNPATHID", "TNPATHID", JdeDataType.Numeric, null, true, true),
        new JdeField("TNTGSETID", "TNTGSETID", JdeDataType.String, 60),
        new JdeField("TNEFFDT", "TNEFFDT", JdeDataType.Date),
        new JdeField("TNPARPTHID", "TNPARPTHID", JdeDataType.Numeric),
        new JdeField("TNANYNDFG", "TNANYNDFG", JdeDataType.String, 2),
        new JdeField("TNQSTGRPID", "TNQSTGRPID", JdeDataType.Numeric),
        new JdeField("TNQUSTID", "TNQUSTID", JdeDataType.Numeric),
        new JdeField("TNANSWID", "TNANSWID", JdeDataType.Numeric),
        new JdeField("TNANSETID", "TNANSETID", JdeDataType.Numeric),
        new JdeField("TNRULSTID", "TNRULSTID", JdeDataType.Numeric),
        new JdeField("TNRULITID", "TNRULITID", JdeDataType.Numeric),
        new JdeField("TNVARLID", "TNVARLID", JdeDataType.Numeric),
        new JdeField("TNSUBSCRID", "TNSUBSCRID", JdeDataType.Numeric),
        new JdeField("TNSEQNBR", "TNSEQNBR", JdeDataType.Numeric),
        new JdeField("TNUSER", "TNUSER", JdeDataType.String, 20),
        new JdeField("TNJOBN", "TNJOBN", JdeDataType.String, 20),
        new JdeField("TNMKEY", "TNMKEY", JdeDataType.String, 30),
        new JdeField("TNUDTTM", "TNUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF170_0", "Primary Key on TNSCRPTID, TNPATHID", new[] { "TNSCRPTID", "TNPATHID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CF170_2", "Index on TNANSWID", new[] { "TNANSWID" })
    };
}
