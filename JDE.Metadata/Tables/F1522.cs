using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1522 - .
/// </summary>
public class F1522 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UTUNITTEMP.
        /// </summary>
        public const string UTUNITTEMP = "UTUNITTEMP";

        /// <summary>
        /// UTUNITTDSC.
        /// </summary>
        public const string UTUNITTDSC = "UTUNITTDSC";

        /// <summary>
        /// UTUNITTAB1.
        /// </summary>
        public const string UTUNITTAB1 = "UTUNITTAB1";

        /// <summary>
        /// UTUNITTAB2.
        /// </summary>
        public const string UTUNITTAB2 = "UTUNITTAB2";

        /// <summary>
        /// UTUNITTAB3.
        /// </summary>
        public const string UTUNITTAB3 = "UTUNITTAB3";

        /// <summary>
        /// UTUTAB1DIS.
        /// </summary>
        public const string UTUTAB1DIS = "UTUTAB1DIS";

        /// <summary>
        /// UTUTAB2DIS.
        /// </summary>
        public const string UTUTAB2DIS = "UTUTAB2DIS";

        /// <summary>
        /// UTUTAB3DIS.
        /// </summary>
        public const string UTUTAB3DIS = "UTUTAB3DIS";

        /// <summary>
        /// UTUSER.
        /// </summary>
        public const string UTUSER = "UTUSER";

        /// <summary>
        /// UTUPMJ.
        /// </summary>
        public const string UTUPMJ = "UTUPMJ";

        /// <summary>
        /// UTUPMT.
        /// </summary>
        public const string UTUPMT = "UTUPMT";

        /// <summary>
        /// UTMKEY.
        /// </summary>
        public const string UTMKEY = "UTMKEY";

        /// <summary>
        /// UTPID.
        /// </summary>
        public const string UTPID = "UTPID";

        /// <summary>
        /// UTUNITTAB4.
        /// </summary>
        public const string UTUNITTAB4 = "UTUNITTAB4";

        /// <summary>
        /// UTUNITTAB5.
        /// </summary>
        public const string UTUNITTAB5 = "UTUNITTAB5";

        /// <summary>
        /// UTUNITTAB6.
        /// </summary>
        public const string UTUNITTAB6 = "UTUNITTAB6";

        /// <summary>
        /// UTUTAB4DIS.
        /// </summary>
        public const string UTUTAB4DIS = "UTUTAB4DIS";

        /// <summary>
        /// UTUTAB5DIS.
        /// </summary>
        public const string UTUTAB5DIS = "UTUTAB5DIS";

        /// <summary>
        /// UTUTAB6DIS.
        /// </summary>
        public const string UTUTAB6DIS = "UTUTAB6DIS";
    }

    /// <inheritdoc />
    public override string TableName => "F1522";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UTUNITTEMP", "UTUNITTEMP", JdeDataType.String, 80, true, true),
        new JdeField("UTUNITTDSC", "UTUNITTDSC", JdeDataType.String, 100),
        new JdeField("UTUNITTAB1", "UTUNITTAB1", JdeDataType.String, 60),
        new JdeField("UTUNITTAB2", "UTUNITTAB2", JdeDataType.String, 60),
        new JdeField("UTUNITTAB3", "UTUNITTAB3", JdeDataType.String, 60),
        new JdeField("UTUTAB1DIS", "UTUTAB1DIS", JdeDataType.String, 2),
        new JdeField("UTUTAB2DIS", "UTUTAB2DIS", JdeDataType.String, 2),
        new JdeField("UTUTAB3DIS", "UTUTAB3DIS", JdeDataType.String, 2),
        new JdeField("UTUSER", "UTUSER", JdeDataType.String, 20),
        new JdeField("UTUPMJ", "UTUPMJ", JdeDataType.Numeric),
        new JdeField("UTUPMT", "UTUPMT", JdeDataType.Numeric),
        new JdeField("UTMKEY", "UTMKEY", JdeDataType.String, 30),
        new JdeField("UTPID", "UTPID", JdeDataType.String, 20),
        new JdeField("UTUNITTAB4", "UTUNITTAB4", JdeDataType.String, 60),
        new JdeField("UTUNITTAB5", "UTUNITTAB5", JdeDataType.String, 60),
        new JdeField("UTUNITTAB6", "UTUNITTAB6", JdeDataType.String, 60),
        new JdeField("UTUTAB4DIS", "UTUTAB4DIS", JdeDataType.String, 2),
        new JdeField("UTUTAB5DIS", "UTUTAB5DIS", JdeDataType.String, 2),
        new JdeField("UTUTAB6DIS", "UTUTAB6DIS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1522_0", "Primary Key on UTUNITTEMP", new[] { "UTUNITTEMP" }, isUnique: true, isPrimaryKey: true)
    };
}
