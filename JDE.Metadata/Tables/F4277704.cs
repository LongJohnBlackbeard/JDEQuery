using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4277704 - .
/// </summary>
public class F4277704 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UCJOBS.
        /// </summary>
        public const string UCJOBS = "UCJOBS";

        /// <summary>
        /// UCUKID.
        /// </summary>
        public const string UCUKID = "UCUKID";

        /// <summary>
        /// UCAN8.
        /// </summary>
        public const string UCAN8 = "UCAN8";

        /// <summary>
        /// UCAN8ALPH.
        /// </summary>
        public const string UCAN8ALPH = "UCAN8ALPH";

        /// <summary>
        /// UCPRIO.
        /// </summary>
        public const string UCPRIO = "UCPRIO";

        /// <summary>
        /// UCCM.
        /// </summary>
        public const string UCCM = "UCCM";

        /// <summary>
        /// UCUFULQTY.
        /// </summary>
        public const string UCUFULQTY = "UCUFULQTY";

        /// <summary>
        /// UCUFULERR.
        /// </summary>
        public const string UCUFULERR = "UCUFULERR";

        /// <summary>
        /// UCURCD.
        /// </summary>
        public const string UCURCD = "UCURCD";

        /// <summary>
        /// UCURDT.
        /// </summary>
        public const string UCURDT = "UCURDT";

        /// <summary>
        /// UCURRF.
        /// </summary>
        public const string UCURRF = "UCURRF";

        /// <summary>
        /// UCURAT.
        /// </summary>
        public const string UCURAT = "UCURAT";

        /// <summary>
        /// UCURAB.
        /// </summary>
        public const string UCURAB = "UCURAB";

        /// <summary>
        /// UCUTIME.
        /// </summary>
        public const string UCUTIME = "UCUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4277704";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UCJOBS", "UCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("UCUKID", "UCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("UCAN8", "UCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UCAN8ALPH", "UCAN8ALPH", JdeDataType.String, 80),
        new JdeField("UCPRIO", "UCPRIO", JdeDataType.String, 2, true, true),
        new JdeField("UCCM", "UCCM", JdeDataType.String, 4),
        new JdeField("UCUFULQTY", "UCUFULQTY", JdeDataType.Numeric),
        new JdeField("UCUFULERR", "UCUFULERR", JdeDataType.String, 20),
        new JdeField("UCURCD", "UCURCD", JdeDataType.String, 4),
        new JdeField("UCURDT", "UCURDT", JdeDataType.Numeric),
        new JdeField("UCURRF", "UCURRF", JdeDataType.String, 30),
        new JdeField("UCURAT", "UCURAT", JdeDataType.Numeric),
        new JdeField("UCURAB", "UCURAB", JdeDataType.Numeric),
        new JdeField("UCUTIME", "UCUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4277704_0", "Primary Key on UCJOBS, UCUKID, UCAN8, UCPRIO", new[] { "UCJOBS", "UCUKID", "UCAN8", "UCPRIO" }, isUnique: true, isPrimaryKey: true)
    };
}
