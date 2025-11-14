using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41025 - .
/// </summary>
public class F41025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCONMCU.
        /// </summary>
        public const string CSCONMCU = "CSCONMCU";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSSHAN.
        /// </summary>
        public const string CSSHAN = "CSSHAN";

        /// <summary>
        /// CSITM.
        /// </summary>
        public const string CSITM = "CSITM";

        /// <summary>
        /// CSLOTN.
        /// </summary>
        public const string CSLOTN = "CSLOTN";

        /// <summary>
        /// CSGLPT.
        /// </summary>
        public const string CSGLPT = "CSGLPT";

        /// <summary>
        /// CSLOTS.
        /// </summary>
        public const string CSLOTS = "CSLOTS";

        /// <summary>
        /// CSLCONDATE.
        /// </summary>
        public const string CSLCONDATE = "CSLCONDATE";

        /// <summary>
        /// CSQTYOHC.
        /// </summary>
        public const string CSQTYOHC = "CSQTYOHC";

        /// <summary>
        /// CSQTYOHC2.
        /// </summary>
        public const string CSQTYOHC2 = "CSQTYOHC2";

        /// <summary>
        /// CSCSQTYITI.
        /// </summary>
        public const string CSCSQTYITI = "CSCSQTYITI";

        /// <summary>
        /// CSCSQTYITI2.
        /// </summary>
        public const string CSCSQTYITI2 = "CSCSQTYITI2";

        /// <summary>
        /// CSCSQTYIT.
        /// </summary>
        public const string CSCSQTYIT = "CSCSQTYIT";

        /// <summary>
        /// CSCSQTYIT2.
        /// </summary>
        public const string CSCSQTYIT2 = "CSCSQTYIT2";

        /// <summary>
        /// CSURCD.
        /// </summary>
        public const string CSURCD = "CSURCD";

        /// <summary>
        /// CSURDT.
        /// </summary>
        public const string CSURDT = "CSURDT";

        /// <summary>
        /// CSURAT.
        /// </summary>
        public const string CSURAT = "CSURAT";

        /// <summary>
        /// CSURAB.
        /// </summary>
        public const string CSURAB = "CSURAB";

        /// <summary>
        /// CSURRF.
        /// </summary>
        public const string CSURRF = "CSURRF";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUTIME.
        /// </summary>
        public const string CSUTIME = "CSUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F41025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCONMCU", "CSCONMCU", JdeDataType.String, 24, true, true),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSSHAN", "CSSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("CSITM", "CSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CSLOTN", "CSLOTN", JdeDataType.String, 60, true, true),
        new JdeField("CSGLPT", "CSGLPT", JdeDataType.String, 8),
        new JdeField("CSLOTS", "CSLOTS", JdeDataType.String, 2),
        new JdeField("CSLCONDATE", "CSLCONDATE", JdeDataType.Numeric),
        new JdeField("CSQTYOHC", "CSQTYOHC", JdeDataType.Numeric),
        new JdeField("CSQTYOHC2", "CSQTYOHC2", JdeDataType.Numeric),
        new JdeField("CSCSQTYITI", "CSCSQTYITI", JdeDataType.Numeric),
        new JdeField("CSCSQTYITI2", "CSCSQTYITI2", JdeDataType.Numeric),
        new JdeField("CSCSQTYIT", "CSCSQTYIT", JdeDataType.Numeric),
        new JdeField("CSCSQTYIT2", "CSCSQTYIT2", JdeDataType.Numeric),
        new JdeField("CSURCD", "CSURCD", JdeDataType.String, 4),
        new JdeField("CSURDT", "CSURDT", JdeDataType.Numeric),
        new JdeField("CSURAT", "CSURAT", JdeDataType.Numeric),
        new JdeField("CSURAB", "CSURAB", JdeDataType.Numeric),
        new JdeField("CSURRF", "CSURRF", JdeDataType.String, 30),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUTIME", "CSUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41025_0", "Primary Key on CSCONMCU, CSAN8, CSSHAN, CSITM, CSLOTN", new[] { "CSCONMCU", "CSAN8", "CSSHAN", "CSITM", "CSLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41025_2", "Index on CSAN8, CSSHAN, CSCONMCU, CSITM, CSLOTN", new[] { "CSAN8", "CSSHAN", "CSCONMCU", "CSITM", "CSLOTN" })
    };
}
