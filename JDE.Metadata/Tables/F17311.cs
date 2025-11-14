using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F17311 - .
/// </summary>
public class F17311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDUKID.
        /// </summary>
        public const string LDUKID = "LDUKID";

        /// <summary>
        /// LDLONG.
        /// </summary>
        public const string LDLONG = "LDLONG";

        /// <summary>
        /// LDLATT.
        /// </summary>
        public const string LDLATT = "LDLATT";

        /// <summary>
        /// LDLEVAT.
        /// </summary>
        public const string LDLEVAT = "LDLEVAT";

        /// <summary>
        /// LDBUILD.
        /// </summary>
        public const string LDBUILD = "LDBUILD";

        /// <summary>
        /// LDFLOOR.
        /// </summary>
        public const string LDFLOOR = "LDFLOOR";

        /// <summary>
        /// LDROOM1.
        /// </summary>
        public const string LDROOM1 = "LDROOM1";

        /// <summary>
        /// LDOTHR1.
        /// </summary>
        public const string LDOTHR1 = "LDOTHR1";

        /// <summary>
        /// LDOTHR2.
        /// </summary>
        public const string LDOTHR2 = "LDOTHR2";

        /// <summary>
        /// LDWHO.
        /// </summary>
        public const string LDWHO = "LDWHO";

        /// <summary>
        /// LDCPHC1.
        /// </summary>
        public const string LDCPHC1 = "LDCPHC1";

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
        /// LDCOUN.
        /// </summary>
        public const string LDCOUN = "LDCOUN";

        /// <summary>
        /// LDADDS.
        /// </summary>
        public const string LDADDS = "LDADDS";

        /// <summary>
        /// LDADDZ.
        /// </summary>
        public const string LDADDZ = "LDADDZ";

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

        /// <summary>
        /// LDNLATT.
        /// </summary>
        public const string LDNLATT = "LDNLATT";

        /// <summary>
        /// LDNLONG.
        /// </summary>
        public const string LDNLONG = "LDNLONG";
    }

    /// <inheritdoc />
    public override string TableName => "F17311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDUKID", "LDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDLONG", "LDLONG", JdeDataType.String, 50),
        new JdeField("LDLATT", "LDLATT", JdeDataType.String, 50),
        new JdeField("LDLEVAT", "LDLEVAT", JdeDataType.String, 50),
        new JdeField("LDBUILD", "LDBUILD", JdeDataType.String, 50),
        new JdeField("LDFLOOR", "LDFLOOR", JdeDataType.String, 50),
        new JdeField("LDROOM1", "LDROOM1", JdeDataType.String, 50),
        new JdeField("LDOTHR1", "LDOTHR1", JdeDataType.String, 50),
        new JdeField("LDOTHR2", "LDOTHR2", JdeDataType.String, 50),
        new JdeField("LDWHO", "LDWHO", JdeDataType.String, 240),
        new JdeField("LDCPHC1", "LDCPHC1", JdeDataType.String, 40),
        new JdeField("LDMLNM", "LDMLNM", JdeDataType.String, 80),
        new JdeField("LDADD1", "LDADD1", JdeDataType.String, 80),
        new JdeField("LDADD2", "LDADD2", JdeDataType.String, 80),
        new JdeField("LDADD3", "LDADD3", JdeDataType.String, 80),
        new JdeField("LDADD4", "LDADD4", JdeDataType.String, 80),
        new JdeField("LDCTY1", "LDCTY1", JdeDataType.String, 50),
        new JdeField("LDCOUN", "LDCOUN", JdeDataType.String, 50),
        new JdeField("LDADDS", "LDADDS", JdeDataType.String, 6),
        new JdeField("LDADDZ", "LDADDZ", JdeDataType.String, 24),
        new JdeField("LDCTR", "LDCTR", JdeDataType.String, 6),
        new JdeField("LDCRTU", "LDCRTU", JdeDataType.String, 20),
        new JdeField("LDCADT", "LDCADT", JdeDataType.Numeric),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric),
        new JdeField("LDNLATT", "LDNLATT", JdeDataType.Numeric),
        new JdeField("LDNLONG", "LDNLONG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F17311_0", "Primary Key on LDUKID", new[] { "LDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
