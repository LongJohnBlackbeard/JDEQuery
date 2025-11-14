using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B39 - .
/// </summary>
public class F76H3B39 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UVH76LECO.
        /// </summary>
        public const string UVH76LECO = "UVH76LECO";

        /// <summary>
        /// UVH76LEDT.
        /// </summary>
        public const string UVH76LEDT = "UVH76LEDT";

        /// <summary>
        /// UVH76EMS.
        /// </summary>
        public const string UVH76EMS = "UVH76EMS";

        /// <summary>
        /// UVUSER1.
        /// </summary>
        public const string UVUSER1 = "UVUSER1";

        /// <summary>
        /// UVPID1.
        /// </summary>
        public const string UVPID1 = "UVPID1";

        /// <summary>
        /// UVVERS.
        /// </summary>
        public const string UVVERS = "UVVERS";

        /// <summary>
        /// UVTORG.
        /// </summary>
        public const string UVTORG = "UVTORG";

        /// <summary>
        /// UVUSER.
        /// </summary>
        public const string UVUSER = "UVUSER";

        /// <summary>
        /// UVPID.
        /// </summary>
        public const string UVPID = "UVPID";

        /// <summary>
        /// UVJOBN.
        /// </summary>
        public const string UVJOBN = "UVJOBN";

        /// <summary>
        /// UVUPMT.
        /// </summary>
        public const string UVUPMT = "UVUPMT";

        /// <summary>
        /// UVUPMJ.
        /// </summary>
        public const string UVUPMJ = "UVUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B39";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UVH76LECO", "UVH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("UVH76LEDT", "UVH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("UVH76EMS", "UVH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("UVUSER1", "UVUSER1", JdeDataType.String, 20, true, true),
        new JdeField("UVPID1", "UVPID1", JdeDataType.String, 20),
        new JdeField("UVVERS", "UVVERS", JdeDataType.String, 20),
        new JdeField("UVTORG", "UVTORG", JdeDataType.String, 20),
        new JdeField("UVUSER", "UVUSER", JdeDataType.String, 20),
        new JdeField("UVPID", "UVPID", JdeDataType.String, 20),
        new JdeField("UVJOBN", "UVJOBN", JdeDataType.String, 20),
        new JdeField("UVUPMT", "UVUPMT", JdeDataType.Numeric),
        new JdeField("UVUPMJ", "UVUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B39_0", "Primary Key on UVH76LECO, UVH76LEDT, UVH76EMS, UVUSER1", new[] { "UVH76LECO", "UVH76LEDT", "UVH76EMS", "UVUSER1" }, isUnique: true, isPrimaryKey: true)
    };
}
