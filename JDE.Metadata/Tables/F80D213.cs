using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D213 - .
/// </summary>
public class F80D213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BOPRDJ.
        /// </summary>
        public const string BOPRDJ = "BOPRDJ";

        /// <summary>
        /// BOMCU.
        /// </summary>
        public const string BOMCU = "BOMCU";

        /// <summary>
        /// BOITM.
        /// </summary>
        public const string BOITM = "BOITM";

        /// <summary>
        /// BOBOAA.
        /// </summary>
        public const string BOBOAA = "BOBOAA";

        /// <summary>
        /// BOBOCN.
        /// </summary>
        public const string BOBOCN = "BOBOCN";

        /// <summary>
        /// BOUSER.
        /// </summary>
        public const string BOUSER = "BOUSER";

        /// <summary>
        /// BOPID.
        /// </summary>
        public const string BOPID = "BOPID";

        /// <summary>
        /// BOMKEY.
        /// </summary>
        public const string BOMKEY = "BOMKEY";

        /// <summary>
        /// BOUTIME.
        /// </summary>
        public const string BOUTIME = "BOUTIME";

        /// <summary>
        /// BOURCD.
        /// </summary>
        public const string BOURCD = "BOURCD";

        /// <summary>
        /// BOURDT.
        /// </summary>
        public const string BOURDT = "BOURDT";

        /// <summary>
        /// BOURAT.
        /// </summary>
        public const string BOURAT = "BOURAT";

        /// <summary>
        /// BOURAB.
        /// </summary>
        public const string BOURAB = "BOURAB";

        /// <summary>
        /// BOURRF.
        /// </summary>
        public const string BOURRF = "BOURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BOPRDJ", "BOPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BOMCU", "BOMCU", JdeDataType.String, 24, true, true),
        new JdeField("BOITM", "BOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BOBOAA", "BOBOAA", JdeDataType.Numeric),
        new JdeField("BOBOCN", "BOBOCN", JdeDataType.Numeric),
        new JdeField("BOUSER", "BOUSER", JdeDataType.String, 20),
        new JdeField("BOPID", "BOPID", JdeDataType.String, 20),
        new JdeField("BOMKEY", "BOMKEY", JdeDataType.String, 30),
        new JdeField("BOUTIME", "BOUTIME", JdeDataType.Date),
        new JdeField("BOURCD", "BOURCD", JdeDataType.String, 4),
        new JdeField("BOURDT", "BOURDT", JdeDataType.Numeric),
        new JdeField("BOURAT", "BOURAT", JdeDataType.Numeric),
        new JdeField("BOURAB", "BOURAB", JdeDataType.Numeric),
        new JdeField("BOURRF", "BOURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D213_0", "Primary Key on BOPRDJ, BOMCU, BOITM", new[] { "BOPRDJ", "BOMCU", "BOITM" }, isUnique: true, isPrimaryKey: true)
    };
}
