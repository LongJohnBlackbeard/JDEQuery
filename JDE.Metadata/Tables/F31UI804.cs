using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31UI804 - .
/// </summary>
public class F31UI804 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WRDG.
        /// </summary>
        public const string WRDG = "WRDG";

        /// <summary>
        /// WRANI.
        /// </summary>
        public const string WRANI = "WRANI";

        /// <summary>
        /// WRANUM.
        /// </summary>
        public const string WRANUM = "WRANUM";

        /// <summary>
        /// WRDCT.
        /// </summary>
        public const string WRDCT = "WRDCT";

        /// <summary>
        /// WRGLPT.
        /// </summary>
        public const string WRGLPT = "WRGLPT";

        /// <summary>
        /// WRCOST.
        /// </summary>
        public const string WRCOST = "WRCOST";

        /// <summary>
        /// WRDOC.
        /// </summary>
        public const string WRDOC = "WRDOC";

        /// <summary>
        /// WRAA.
        /// </summary>
        public const string WRAA = "WRAA";

        /// <summary>
        /// WRDCTO.
        /// </summary>
        public const string WRDCTO = "WRDCTO";

        /// <summary>
        /// WRDS40.
        /// </summary>
        public const string WRDS40 = "WRDS40";

        /// <summary>
        /// WRJOBS.
        /// </summary>
        public const string WRJOBS = "WRJOBS";

        /// <summary>
        /// WRCTID.
        /// </summary>
        public const string WRCTID = "WRCTID";

        /// <summary>
        /// WRLNID.
        /// </summary>
        public const string WRLNID = "WRLNID";

        /// <summary>
        /// WRICU.
        /// </summary>
        public const string WRICU = "WRICU";
    }

    /// <inheritdoc />
    public override string TableName => "F31UI804";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WRDG", "WRDG", JdeDataType.Numeric),
        new JdeField("WRANI", "WRANI", JdeDataType.String, 58),
        new JdeField("WRANUM", "WRANUM", JdeDataType.Numeric),
        new JdeField("WRDCT", "WRDCT", JdeDataType.String, 4),
        new JdeField("WRGLPT", "WRGLPT", JdeDataType.String, 8),
        new JdeField("WRCOST", "WRCOST", JdeDataType.String, 6),
        new JdeField("WRDOC", "WRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WRAA", "WRAA", JdeDataType.Numeric),
        new JdeField("WRDCTO", "WRDCTO", JdeDataType.String, 4),
        new JdeField("WRDS40", "WRDS40", JdeDataType.String, 80),
        new JdeField("WRJOBS", "WRJOBS", JdeDataType.Numeric),
        new JdeField("WRCTID", "WRCTID", JdeDataType.String, 30),
        new JdeField("WRLNID", "WRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WRICU", "WRICU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31UI804_0", "Primary Key on WRDOC, WRLNID", new[] { "WRDOC", "WRLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31UI804_2", "Index on WRJOBS", new[] { "WRJOBS" })
    };
}
