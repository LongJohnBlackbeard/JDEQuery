using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980014D - .
/// </summary>
public class F980014D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDOBNM.
        /// </summary>
        public const string MDOBNM = "MDOBNM";

        /// <summary>
        /// MDUPMJ.
        /// </summary>
        public const string MDUPMJ = "MDUPMJ";

        /// <summary>
        /// MDUPMT.
        /// </summary>
        public const string MDUPMT = "MDUPMT";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDJOBN.
        /// </summary>
        public const string MDJOBN = "MDJOBN";

        /// <summary>
        /// MDMMDRN.
        /// </summary>
        public const string MDMMDRN = "MDMMDRN";

        /// <summary>
        /// MDMMDS.
        /// </summary>
        public const string MDMMDS = "MDMMDS";

        /// <summary>
        /// MDMMUID.
        /// </summary>
        public const string MDMMUID = "MDMMUID";

        /// <summary>
        /// MDMMSK.
        /// </summary>
        public const string MDMMSK = "MDMMSK";
    }

    /// <inheritdoc />
    public override string TableName => "F980014D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDOBNM", "MDOBNM", JdeDataType.String, 20),
        new JdeField("MDUPMJ", "MDUPMJ", JdeDataType.Numeric),
        new JdeField("MDUPMT", "MDUPMT", JdeDataType.Numeric),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDJOBN", "MDJOBN", JdeDataType.String, 20),
        new JdeField("MDMMDRN", "MDMMDRN", JdeDataType.Numeric, null, true, true),
        new JdeField("MDMMDS", "MDMMDS", JdeDataType.String),
        new JdeField("MDMMUID", "MDMMUID", JdeDataType.Numeric, null, true, true),
        new JdeField("MDMMSK", "MDMMSK", JdeDataType.String, 200)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980014D_0", "Primary Key on MDMMUID, MDMMDRN", new[] { "MDMMUID", "MDMMDRN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F980014D_2", "Index on MDUSER, MDOBNM, SYS_NC00011$", new[] { "MDUSER", "MDOBNM", "SYS_NC00011$" }),
        new JdeIndex("F980014D_3", "Index on SYS_NC00012$, SYS_NC00011$", new[] { "SYS_NC00012$", "SYS_NC00011$" }),
        new JdeIndex("F980014D_4", "Index on SYS_NC00013$, SYS_NC00012$, SYS_NC00011$", new[] { "SYS_NC00013$", "SYS_NC00012$", "SYS_NC00011$" }),
        new JdeIndex("F980014D_5", "Index on MDMMUID, MDMMSK, MDMMDRN", new[] { "MDMMUID", "MDMMSK", "MDMMDRN" }),
        new JdeIndex("F980014D_6", "Index on MDUSER, MDOBNM, MDMMDRN", new[] { "MDUSER", "MDOBNM", "MDMMDRN" })
    };
}
