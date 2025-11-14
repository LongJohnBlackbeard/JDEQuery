using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F17220W - .
/// </summary>
public class F17220W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDUOID.
        /// </summary>
        public const string LDUOID = "LDUOID";

        /// <summary>
        /// LDUKID.
        /// </summary>
        public const string LDUKID = "LDUKID";

        /// <summary>
        /// LDNLATT.
        /// </summary>
        public const string LDNLATT = "LDNLATT";

        /// <summary>
        /// LDNLONG.
        /// </summary>
        public const string LDNLONG = "LDNLONG";

        /// <summary>
        /// LDLATT.
        /// </summary>
        public const string LDLATT = "LDLATT";

        /// <summary>
        /// LDLONG.
        /// </summary>
        public const string LDLONG = "LDLONG";

        /// <summary>
        /// LDMLNM.
        /// </summary>
        public const string LDMLNM = "LDMLNM";

        /// <summary>
        /// LDADD1.
        /// </summary>
        public const string LDADD1 = "LDADD1";

        /// <summary>
        /// LDADD2.
        /// </summary>
        public const string LDADD2 = "LDADD2";

        /// <summary>
        /// LDADD3.
        /// </summary>
        public const string LDADD3 = "LDADD3";

        /// <summary>
        /// LDADD4.
        /// </summary>
        public const string LDADD4 = "LDADD4";

        /// <summary>
        /// LDCTY1.
        /// </summary>
        public const string LDCTY1 = "LDCTY1";

        /// <summary>
        /// LDADDS.
        /// </summary>
        public const string LDADDS = "LDADDS";

        /// <summary>
        /// LDADDZ.
        /// </summary>
        public const string LDADDZ = "LDADDZ";

        /// <summary>
        /// LDCOUN.
        /// </summary>
        public const string LDCOUN = "LDCOUN";

        /// <summary>
        /// LDCTR.
        /// </summary>
        public const string LDCTR = "LDCTR";

        /// <summary>
        /// LDCRTU.
        /// </summary>
        public const string LDCRTU = "LDCRTU";

        /// <summary>
        /// LDCADT.
        /// </summary>
        public const string LDCADT = "LDCADT";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F17220W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDUOID", "LDUOID", JdeDataType.String, 100, true, true),
        new JdeField("LDUKID", "LDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDNLATT", "LDNLATT", JdeDataType.Numeric),
        new JdeField("LDNLONG", "LDNLONG", JdeDataType.Numeric),
        new JdeField("LDLATT", "LDLATT", JdeDataType.String, 50),
        new JdeField("LDLONG", "LDLONG", JdeDataType.String, 50),
        new JdeField("LDMLNM", "LDMLNM", JdeDataType.String, 80),
        new JdeField("LDADD1", "LDADD1", JdeDataType.String, 80),
        new JdeField("LDADD2", "LDADD2", JdeDataType.String, 80),
        new JdeField("LDADD3", "LDADD3", JdeDataType.String, 80),
        new JdeField("LDADD4", "LDADD4", JdeDataType.String, 80),
        new JdeField("LDCTY1", "LDCTY1", JdeDataType.String, 50),
        new JdeField("LDADDS", "LDADDS", JdeDataType.String, 6),
        new JdeField("LDADDZ", "LDADDZ", JdeDataType.String, 24),
        new JdeField("LDCOUN", "LDCOUN", JdeDataType.String, 50),
        new JdeField("LDCTR", "LDCTR", JdeDataType.String, 6),
        new JdeField("LDCRTU", "LDCRTU", JdeDataType.String, 20),
        new JdeField("LDCADT", "LDCADT", JdeDataType.Numeric),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F17220W_0", "Primary Key on LDUOID, LDUKID", new[] { "LDUOID", "LDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
