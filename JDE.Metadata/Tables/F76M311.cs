using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M311 - .
/// </summary>
public class F76M311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MBKCO.
        /// </summary>
        public const string MBKCO = "MBKCO";

        /// <summary>
        /// MBDCT.
        /// </summary>
        public const string MBDCT = "MBDCT";

        /// <summary>
        /// MBDOC.
        /// </summary>
        public const string MBDOC = "MBDOC";

        /// <summary>
        /// MBSFX.
        /// </summary>
        public const string MBSFX = "MBSFX";

        /// <summary>
        /// MBDREM.
        /// </summary>
        public const string MBDREM = "MBDREM";

        /// <summary>
        /// MBDFRE.
        /// </summary>
        public const string MBDFRE = "MBDFRE";

        /// <summary>
        /// MBSTAM.
        /// </summary>
        public const string MBSTAM = "MBSTAM";

        /// <summary>
        /// MBCTAM.
        /// </summary>
        public const string MBCTAM = "MBCTAM";

        /// <summary>
        /// MBCO.
        /// </summary>
        public const string MBCO = "MBCO";

        /// <summary>
        /// MBCRCD.
        /// </summary>
        public const string MBCRCD = "MBCRCD";

        /// <summary>
        /// MBBCRC.
        /// </summary>
        public const string MBBCRC = "MBBCRC";

        /// <summary>
        /// MBGFL1.
        /// </summary>
        public const string MBGFL1 = "MBGFL1";

        /// <summary>
        /// MBUSER.
        /// </summary>
        public const string MBUSER = "MBUSER";

        /// <summary>
        /// MBPID.
        /// </summary>
        public const string MBPID = "MBPID";

        /// <summary>
        /// MBJOBN.
        /// </summary>
        public const string MBJOBN = "MBJOBN";

        /// <summary>
        /// MBUPMJ.
        /// </summary>
        public const string MBUPMJ = "MBUPMJ";

        /// <summary>
        /// MBUPMT.
        /// </summary>
        public const string MBUPMT = "MBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MBKCO", "MBKCO", JdeDataType.String, 10, true, true),
        new JdeField("MBDCT", "MBDCT", JdeDataType.String, 4, true, true),
        new JdeField("MBDOC", "MBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MBSFX", "MBSFX", JdeDataType.String, 6, true, true),
        new JdeField("MBDREM", "MBDREM", JdeDataType.Numeric),
        new JdeField("MBDFRE", "MBDFRE", JdeDataType.Numeric),
        new JdeField("MBSTAM", "MBSTAM", JdeDataType.Numeric),
        new JdeField("MBCTAM", "MBCTAM", JdeDataType.Numeric),
        new JdeField("MBCO", "MBCO", JdeDataType.String, 10),
        new JdeField("MBCRCD", "MBCRCD", JdeDataType.String, 6),
        new JdeField("MBBCRC", "MBBCRC", JdeDataType.String, 6),
        new JdeField("MBGFL1", "MBGFL1", JdeDataType.String, 2),
        new JdeField("MBUSER", "MBUSER", JdeDataType.String, 20),
        new JdeField("MBPID", "MBPID", JdeDataType.String, 20),
        new JdeField("MBJOBN", "MBJOBN", JdeDataType.String, 20),
        new JdeField("MBUPMJ", "MBUPMJ", JdeDataType.Numeric),
        new JdeField("MBUPMT", "MBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M311_0", "Primary Key on MBKCO, MBDCT, MBDOC, MBSFX", new[] { "MBKCO", "MBDCT", "MBDOC", "MBSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
