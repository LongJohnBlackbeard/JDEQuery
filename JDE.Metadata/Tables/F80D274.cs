using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D274 - .
/// </summary>
public class F80D274 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBPRDJ.
        /// </summary>
        public const string PBPRDJ = "PBPRDJ";

        /// <summary>
        /// PBCO.
        /// </summary>
        public const string PBCO = "PBCO";

        /// <summary>
        /// PBCABRND.
        /// </summary>
        public const string PBCABRND = "PBCABRND";

        /// <summary>
        /// PBAMPRF.
        /// </summary>
        public const string PBAMPRF = "PBAMPRF";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBMKEY.
        /// </summary>
        public const string PBMKEY = "PBMKEY";

        /// <summary>
        /// PBUTIME.
        /// </summary>
        public const string PBUTIME = "PBUTIME";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";

        /// <summary>
        /// PBURRF.
        /// </summary>
        public const string PBURRF = "PBURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D274";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBPRDJ", "PBPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PBCO", "PBCO", JdeDataType.String, 10, true, true),
        new JdeField("PBCABRND", "PBCABRND", JdeDataType.String, 24, true, true),
        new JdeField("PBAMPRF", "PBAMPRF", JdeDataType.Numeric),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBMKEY", "PBMKEY", JdeDataType.String, 30),
        new JdeField("PBUTIME", "PBUTIME", JdeDataType.Date),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric),
        new JdeField("PBURRF", "PBURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D274_0", "Primary Key on PBPRDJ, PBCO, PBCABRND", new[] { "PBPRDJ", "PBCO", "PBCABRND" }, isUnique: true, isPrimaryKey: true)
    };
}
