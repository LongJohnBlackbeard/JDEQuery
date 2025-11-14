using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48128 - .
/// </summary>
public class F48128 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WITYKY.
        /// </summary>
        public const string WITYKY = "WITYKY";

        /// <summary>
        /// WITKEY.
        /// </summary>
        public const string WITKEY = "WITKEY";

        /// <summary>
        /// WITRAR.
        /// </summary>
        public const string WITRAR = "WITRAR";

        /// <summary>
        /// WIGLC.
        /// </summary>
        public const string WIGLC = "WIGLC";

        /// <summary>
        /// WIPRET.
        /// </summary>
        public const string WIPRET = "WIPRET";

        /// <summary>
        /// WIRGLC.
        /// </summary>
        public const string WIRGLC = "WIRGLC";

        /// <summary>
        /// WIRCTL.
        /// </summary>
        public const string WIRCTL = "WIRCTL";

        /// <summary>
        /// WICRRM.
        /// </summary>
        public const string WICRRM = "WICRRM";

        /// <summary>
        /// WIUPMJ.
        /// </summary>
        public const string WIUPMJ = "WIUPMJ";

        /// <summary>
        /// WIUPMT.
        /// </summary>
        public const string WIUPMT = "WIUPMT";

        /// <summary>
        /// WIPID.
        /// </summary>
        public const string WIPID = "WIPID";

        /// <summary>
        /// WIJOBN.
        /// </summary>
        public const string WIJOBN = "WIJOBN";

        /// <summary>
        /// WIUSER.
        /// </summary>
        public const string WIUSER = "WIUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F48128";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WITYKY", "WITYKY", JdeDataType.String, 2, true, true),
        new JdeField("WITKEY", "WITKEY", JdeDataType.String, 24, true, true),
        new JdeField("WITRAR", "WITRAR", JdeDataType.String, 6),
        new JdeField("WIGLC", "WIGLC", JdeDataType.String, 8),
        new JdeField("WIPRET", "WIPRET", JdeDataType.Numeric),
        new JdeField("WIRGLC", "WIRGLC", JdeDataType.String, 8),
        new JdeField("WIRCTL", "WIRCTL", JdeDataType.String, 2),
        new JdeField("WICRRM", "WICRRM", JdeDataType.String, 2),
        new JdeField("WIUPMJ", "WIUPMJ", JdeDataType.Numeric),
        new JdeField("WIUPMT", "WIUPMT", JdeDataType.Numeric),
        new JdeField("WIPID", "WIPID", JdeDataType.String, 20),
        new JdeField("WIJOBN", "WIJOBN", JdeDataType.String, 20),
        new JdeField("WIUSER", "WIUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48128_0", "Primary Key on WITYKY, WITKEY", new[] { "WITYKY", "WITKEY" }, isUnique: true, isPrimaryKey: true)
    };
}
