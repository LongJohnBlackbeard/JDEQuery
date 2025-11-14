using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F907011N - .
/// </summary>
public class F907011N : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DEFRMREL.
        /// </summary>
        public const string DEFRMREL = "DEFRMREL";

        /// <summary>
        /// DETHRREL.
        /// </summary>
        public const string DETHRREL = "DETHRREL";

        /// <summary>
        /// DEEVNTNAME.
        /// </summary>
        public const string DEEVNTNAME = "DEEVNTNAME";

        /// <summary>
        /// DEEVNTSNAME.
        /// </summary>
        public const string DEEVNTSNAME = "DEEVNTSNAME";

        /// <summary>
        /// DEEVNTTYPE.
        /// </summary>
        public const string DEEVNTTYPE = "DEEVNTTYPE";

        /// <summary>
        /// DEEVNTSCOPE.
        /// </summary>
        public const string DEEVNTSCOPE = "DEEVNTSCOPE";

        /// <summary>
        /// DEFUTUSE01.
        /// </summary>
        public const string DEFUTUSE01 = "DEFUTUSE01";

        /// <summary>
        /// DEFUTUSE03.
        /// </summary>
        public const string DEFUTUSE03 = "DEFUTUSE03";

        /// <summary>
        /// DEFUTUSE04.
        /// </summary>
        public const string DEFUTUSE04 = "DEFUTUSE04";

        /// <summary>
        /// DEUPMJ.
        /// </summary>
        public const string DEUPMJ = "DEUPMJ";

        /// <summary>
        /// DEUPMT.
        /// </summary>
        public const string DEUPMT = "DEUPMT";

        /// <summary>
        /// DEPID.
        /// </summary>
        public const string DEPID = "DEPID";

        /// <summary>
        /// DEUSER.
        /// </summary>
        public const string DEUSER = "DEUSER";

        /// <summary>
        /// DEJOBN.
        /// </summary>
        public const string DEJOBN = "DEJOBN";

        /// <summary>
        /// DECHGF.
        /// </summary>
        public const string DECHGF = "DECHGF";
    }

    /// <inheritdoc />
    public override string TableName => "F907011N";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DEFRMREL", "DEFRMREL", JdeDataType.String, 20, true, true),
        new JdeField("DETHRREL", "DETHRREL", JdeDataType.String, 20, true, true),
        new JdeField("DEEVNTNAME", "DEEVNTNAME", JdeDataType.String, 20, true, true),
        new JdeField("DEEVNTSNAME", "DEEVNTSNAME", JdeDataType.String, 20, true, true),
        new JdeField("DEEVNTTYPE", "DEEVNTTYPE", JdeDataType.String, 10),
        new JdeField("DEEVNTSCOPE", "DEEVNTSCOPE", JdeDataType.String, 60),
        new JdeField("DEFUTUSE01", "DEFUTUSE01", JdeDataType.String, 2),
        new JdeField("DEFUTUSE03", "DEFUTUSE03", JdeDataType.String, 40),
        new JdeField("DEFUTUSE04", "DEFUTUSE04", JdeDataType.Numeric),
        new JdeField("DEUPMJ", "DEUPMJ", JdeDataType.Numeric),
        new JdeField("DEUPMT", "DEUPMT", JdeDataType.Numeric),
        new JdeField("DEPID", "DEPID", JdeDataType.String, 20),
        new JdeField("DEUSER", "DEUSER", JdeDataType.String, 20),
        new JdeField("DEJOBN", "DEJOBN", JdeDataType.String, 20),
        new JdeField("DECHGF", "DECHGF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F907011N_0", "Primary Key on DEFRMREL, DETHRREL, DEEVNTNAME, DEEVNTSNAME", new[] { "DEFRMREL", "DETHRREL", "DEEVNTNAME", "DEEVNTSNAME" }, isUnique: true, isPrimaryKey: true)
    };
}
