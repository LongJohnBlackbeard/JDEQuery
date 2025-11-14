using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0770 - .
/// </summary>
public class F31B0770 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BMBMID.
        /// </summary>
        public const string BMBMID = "BMBMID";

        /// <summary>
        /// BMBRAND.
        /// </summary>
        public const string BMBRAND = "BMBRAND";

        /// <summary>
        /// BMBRDSC.
        /// </summary>
        public const string BMBRDSC = "BMBRDSC";

        /// <summary>
        /// BMBMAFLG.
        /// </summary>
        public const string BMBMAFLG = "BMBMAFLG";

        /// <summary>
        /// BMBMCC01.
        /// </summary>
        public const string BMBMCC01 = "BMBMCC01";

        /// <summary>
        /// BMBMCC02.
        /// </summary>
        public const string BMBMCC02 = "BMBMCC02";

        /// <summary>
        /// BMBMCC03.
        /// </summary>
        public const string BMBMCC03 = "BMBMCC03";

        /// <summary>
        /// BMBMCC04.
        /// </summary>
        public const string BMBMCC04 = "BMBMCC04";

        /// <summary>
        /// BMBMCC05.
        /// </summary>
        public const string BMBMCC05 = "BMBMCC05";

        /// <summary>
        /// BMBMCC06.
        /// </summary>
        public const string BMBMCC06 = "BMBMCC06";

        /// <summary>
        /// BMBMCC07.
        /// </summary>
        public const string BMBMCC07 = "BMBMCC07";

        /// <summary>
        /// BMBMCC08.
        /// </summary>
        public const string BMBMCC08 = "BMBMCC08";

        /// <summary>
        /// BMBMCC09.
        /// </summary>
        public const string BMBMCC09 = "BMBMCC09";

        /// <summary>
        /// BMBMCC10.
        /// </summary>
        public const string BMBMCC10 = "BMBMCC10";

        /// <summary>
        /// BMURAB.
        /// </summary>
        public const string BMURAB = "BMURAB";

        /// <summary>
        /// BMURAT.
        /// </summary>
        public const string BMURAT = "BMURAT";

        /// <summary>
        /// BMURCD.
        /// </summary>
        public const string BMURCD = "BMURCD";

        /// <summary>
        /// BMURDT.
        /// </summary>
        public const string BMURDT = "BMURDT";

        /// <summary>
        /// BMURRF.
        /// </summary>
        public const string BMURRF = "BMURRF";

        /// <summary>
        /// BMJOBN.
        /// </summary>
        public const string BMJOBN = "BMJOBN";

        /// <summary>
        /// BMPID.
        /// </summary>
        public const string BMPID = "BMPID";

        /// <summary>
        /// BMTDAY.
        /// </summary>
        public const string BMTDAY = "BMTDAY";

        /// <summary>
        /// BMUPMJ.
        /// </summary>
        public const string BMUPMJ = "BMUPMJ";

        /// <summary>
        /// BMUSER.
        /// </summary>
        public const string BMUSER = "BMUSER";

        /// <summary>
        /// BMWAB.
        /// </summary>
        public const string BMWAB = "BMWAB";

        /// <summary>
        /// BMWCD.
        /// </summary>
        public const string BMWCD = "BMWCD";

        /// <summary>
        /// BMWMDT.
        /// </summary>
        public const string BMWMDT = "BMWMDT";

        /// <summary>
        /// BMWNUM.
        /// </summary>
        public const string BMWNUM = "BMWNUM";

        /// <summary>
        /// BMWRF.
        /// </summary>
        public const string BMWRF = "BMWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0770";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BMBMID", "BMBMID", JdeDataType.Numeric, null, true, true),
        new JdeField("BMBRAND", "BMBRAND", JdeDataType.String, 20),
        new JdeField("BMBRDSC", "BMBRDSC", JdeDataType.String, 60),
        new JdeField("BMBMAFLG", "BMBMAFLG", JdeDataType.String, 2),
        new JdeField("BMBMCC01", "BMBMCC01", JdeDataType.String, 20),
        new JdeField("BMBMCC02", "BMBMCC02", JdeDataType.String, 20),
        new JdeField("BMBMCC03", "BMBMCC03", JdeDataType.String, 20),
        new JdeField("BMBMCC04", "BMBMCC04", JdeDataType.String, 20),
        new JdeField("BMBMCC05", "BMBMCC05", JdeDataType.String, 20),
        new JdeField("BMBMCC06", "BMBMCC06", JdeDataType.String, 20),
        new JdeField("BMBMCC07", "BMBMCC07", JdeDataType.String, 20),
        new JdeField("BMBMCC08", "BMBMCC08", JdeDataType.String, 20),
        new JdeField("BMBMCC09", "BMBMCC09", JdeDataType.String, 20),
        new JdeField("BMBMCC10", "BMBMCC10", JdeDataType.String, 20),
        new JdeField("BMURAB", "BMURAB", JdeDataType.Numeric),
        new JdeField("BMURAT", "BMURAT", JdeDataType.Numeric),
        new JdeField("BMURCD", "BMURCD", JdeDataType.String, 4),
        new JdeField("BMURDT", "BMURDT", JdeDataType.Numeric),
        new JdeField("BMURRF", "BMURRF", JdeDataType.String, 30),
        new JdeField("BMJOBN", "BMJOBN", JdeDataType.String, 20),
        new JdeField("BMPID", "BMPID", JdeDataType.String, 20),
        new JdeField("BMTDAY", "BMTDAY", JdeDataType.Numeric),
        new JdeField("BMUPMJ", "BMUPMJ", JdeDataType.Numeric),
        new JdeField("BMUSER", "BMUSER", JdeDataType.String, 20),
        new JdeField("BMWAB", "BMWAB", JdeDataType.Numeric),
        new JdeField("BMWCD", "BMWCD", JdeDataType.String, 6),
        new JdeField("BMWMDT", "BMWMDT", JdeDataType.Numeric),
        new JdeField("BMWNUM", "BMWNUM", JdeDataType.Numeric),
        new JdeField("BMWRF", "BMWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0770_0", "Primary Key on BMBMID", new[] { "BMBMID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B0770_2", "Index on BMBRAND, BMBMID", new[] { "BMBRAND", "BMBMID" })
    };
}
