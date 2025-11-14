using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1501BD - .
/// </summary>
public class F1501BD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NEDOCO.
        /// </summary>
        public const string NEDOCO = "NEDOCO";

        /// <summary>
        /// NELSVR.
        /// </summary>
        public const string NELSVR = "NELSVR";

        /// <summary>
        /// NELNGP.
        /// </summary>
        public const string NELNGP = "NELNGP";

        /// <summary>
        /// NEDL01.
        /// </summary>
        public const string NEDL01 = "NEDL01";

        /// <summary>
        /// NEUSER.
        /// </summary>
        public const string NEUSER = "NEUSER";

        /// <summary>
        /// NEPID.
        /// </summary>
        public const string NEPID = "NEPID";

        /// <summary>
        /// NEUPMJ.
        /// </summary>
        public const string NEUPMJ = "NEUPMJ";

        /// <summary>
        /// NEUPMT.
        /// </summary>
        public const string NEUPMT = "NEUPMT";

        /// <summary>
        /// NEJOBN.
        /// </summary>
        public const string NEJOBN = "NEJOBN";

        /// <summary>
        /// NETORG.
        /// </summary>
        public const string NETORG = "NETORG";

        /// <summary>
        /// NEENTJ.
        /// </summary>
        public const string NEENTJ = "NEENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1501BD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NEDOCO", "NEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NELSVR", "NELSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NELNGP", "NELNGP", JdeDataType.String, 4, true, true),
        new JdeField("NEDL01", "NEDL01", JdeDataType.String, 60),
        new JdeField("NEUSER", "NEUSER", JdeDataType.String, 20),
        new JdeField("NEPID", "NEPID", JdeDataType.String, 20),
        new JdeField("NEUPMJ", "NEUPMJ", JdeDataType.Numeric),
        new JdeField("NEUPMT", "NEUPMT", JdeDataType.Numeric),
        new JdeField("NEJOBN", "NEJOBN", JdeDataType.String, 20),
        new JdeField("NETORG", "NETORG", JdeDataType.String, 20),
        new JdeField("NEENTJ", "NEENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1501BD_0", "Primary Key on NEDOCO, NELSVR, NELNGP", new[] { "NEDOCO", "NELSVR", "NELNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
