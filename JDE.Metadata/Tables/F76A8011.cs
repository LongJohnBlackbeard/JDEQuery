using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8011 - .
/// </summary>
public class F76A8011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PACO.
        /// </summary>
        public const string PACO = "PACO";

        /// <summary>
        /// PATAX.
        /// </summary>
        public const string PATAX = "PATAX";

        /// <summary>
        /// PAAN8.
        /// </summary>
        public const string PAAN8 = "PAAN8";

        /// <summary>
        /// PATX1.
        /// </summary>
        public const string PATX1 = "PATX1";

        /// <summary>
        /// PADMTM.
        /// </summary>
        public const string PADMTM = "PADMTM";

        /// <summary>
        /// PADMTY.
        /// </summary>
        public const string PADMTY = "PADMTY";

        /// <summary>
        /// PAAVEN.
        /// </summary>
        public const string PAAVEN = "PAAVEN";

        /// <summary>
        /// PAEFTJ.
        /// </summary>
        public const string PAEFTJ = "PAEFTJ";

        /// <summary>
        /// PAVR01.
        /// </summary>
        public const string PAVR01 = "PAVR01";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAURC1.
        /// </summary>
        public const string PAURC1 = "PAURC1";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";

        /// <summary>
        /// PAARGCN.
        /// </summary>
        public const string PAARGCN = "PAARGCN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PACO", "PACO", JdeDataType.String, 10, true, true),
        new JdeField("PATAX", "PATAX", JdeDataType.String, 40),
        new JdeField("PAAN8", "PAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PATX1", "PATX1", JdeDataType.String, 32),
        new JdeField("PADMTM", "PADMTM", JdeDataType.Numeric, null, true, true),
        new JdeField("PADMTY", "PADMTY", JdeDataType.Numeric, null, true, true),
        new JdeField("PAAVEN", "PAAVEN", JdeDataType.String, 2),
        new JdeField("PAEFTJ", "PAEFTJ", JdeDataType.Numeric),
        new JdeField("PAVR01", "PAVR01", JdeDataType.String, 50),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAURC1", "PAURC1", JdeDataType.String, 6),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PAARGCN", "PAARGCN", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8011_0", "Primary Key on PACO, PAAN8, PADMTM, PADMTY", new[] { "PACO", "PAAN8", "PADMTM", "PADMTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A8011_2", "Index on PATAX, PATX1, PADMTM, PADMTY", new[] { "PATAX", "PATX1", "PADMTM", "PADMTY" })
    };
}
