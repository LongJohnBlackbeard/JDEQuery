using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L3011 - .
/// </summary>
public class F74L3011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MIDOC.
        /// </summary>
        public const string MIDOC = "MIDOC";

        /// <summary>
        /// MIDCT.
        /// </summary>
        public const string MIDCT = "MIDCT";

        /// <summary>
        /// MIKCO.
        /// </summary>
        public const string MIKCO = "MIKCO";

        /// <summary>
        /// MIL74MINV.
        /// </summary>
        public const string MIL74MINV = "MIL74MINV";

        /// <summary>
        /// MIJOBN.
        /// </summary>
        public const string MIJOBN = "MIJOBN";

        /// <summary>
        /// MIPID.
        /// </summary>
        public const string MIPID = "MIPID";

        /// <summary>
        /// MIUPMJ.
        /// </summary>
        public const string MIUPMJ = "MIUPMJ";

        /// <summary>
        /// MIUPMT.
        /// </summary>
        public const string MIUPMT = "MIUPMT";

        /// <summary>
        /// MIUSER.
        /// </summary>
        public const string MIUSER = "MIUSER";

        /// <summary>
        /// MITORG.
        /// </summary>
        public const string MITORG = "MITORG";
    }

    /// <inheritdoc />
    public override string TableName => "F74L3011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MIDOC", "MIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MIDCT", "MIDCT", JdeDataType.String, 4, true, true),
        new JdeField("MIKCO", "MIKCO", JdeDataType.String, 10, true, true),
        new JdeField("MIL74MINV", "MIL74MINV", JdeDataType.String, 100),
        new JdeField("MIJOBN", "MIJOBN", JdeDataType.String, 20),
        new JdeField("MIPID", "MIPID", JdeDataType.String, 20),
        new JdeField("MIUPMJ", "MIUPMJ", JdeDataType.Numeric),
        new JdeField("MIUPMT", "MIUPMT", JdeDataType.Numeric),
        new JdeField("MIUSER", "MIUSER", JdeDataType.String, 20),
        new JdeField("MITORG", "MITORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L3011_0", "Primary Key on MIDOC, MIDCT, MIKCO", new[] { "MIDOC", "MIDCT", "MIKCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74L3011_2", "Index on MIL74MINV", new[] { "MIL74MINV" })
    };
}
