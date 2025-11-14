using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A08 - .
/// </summary>
public class F76A08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFKCO.
        /// </summary>
        public const string CFKCO = "CFKCO";

        /// <summary>
        /// CFDCT.
        /// </summary>
        public const string CFDCT = "CFDCT";

        /// <summary>
        /// CFDOC.
        /// </summary>
        public const string CFDOC = "CFDOC";

        /// <summary>
        /// CFPNO.
        /// </summary>
        public const string CFPNO = "CFPNO";

        /// <summary>
        /// CFATXA.
        /// </summary>
        public const string CFATXA = "CFATXA";

        /// <summary>
        /// CFATXN.
        /// </summary>
        public const string CFATXN = "CFATXN";

        /// <summary>
        /// CFAG.
        /// </summary>
        public const string CFAG = "CFAG";

        /// <summary>
        /// CFCTXA.
        /// </summary>
        public const string CFCTXA = "CFCTXA";

        /// <summary>
        /// CFCTXN.
        /// </summary>
        public const string CFCTXN = "CFCTXN";

        /// <summary>
        /// CFACR.
        /// </summary>
        public const string CFACR = "CFACR";

        /// <summary>
        /// CFSTA1.
        /// </summary>
        public const string CFSTA1 = "CFSTA1";

        /// <summary>
        /// CFSTA2.
        /// </summary>
        public const string CFSTA2 = "CFSTA2";

        /// <summary>
        /// CFSTA3.
        /// </summary>
        public const string CFSTA3 = "CFSTA3";

        /// <summary>
        /// CFSTA4.
        /// </summary>
        public const string CFSTA4 = "CFSTA4";

        /// <summary>
        /// CFSTA5.
        /// </summary>
        public const string CFSTA5 = "CFSTA5";

        /// <summary>
        /// CFBA01.
        /// </summary>
        public const string CFBA01 = "CFBA01";

        /// <summary>
        /// CFBA02.
        /// </summary>
        public const string CFBA02 = "CFBA02";

        /// <summary>
        /// CFBA03.
        /// </summary>
        public const string CFBA03 = "CFBA03";

        /// <summary>
        /// CFBA04.
        /// </summary>
        public const string CFBA04 = "CFBA04";

        /// <summary>
        /// CFBA05.
        /// </summary>
        public const string CFBA05 = "CFBA05";

        /// <summary>
        /// CFURRF.
        /// </summary>
        public const string CFURRF = "CFURRF";

        /// <summary>
        /// CFURCD.
        /// </summary>
        public const string CFURCD = "CFURCD";

        /// <summary>
        /// CFURDT.
        /// </summary>
        public const string CFURDT = "CFURDT";

        /// <summary>
        /// CFURAT.
        /// </summary>
        public const string CFURAT = "CFURAT";

        /// <summary>
        /// CFURAB.
        /// </summary>
        public const string CFURAB = "CFURAB";

        /// <summary>
        /// CFPID.
        /// </summary>
        public const string CFPID = "CFPID";

        /// <summary>
        /// CFUPMJ.
        /// </summary>
        public const string CFUPMJ = "CFUPMJ";

        /// <summary>
        /// CFTDAY.
        /// </summary>
        public const string CFTDAY = "CFTDAY";

        /// <summary>
        /// CFJOBS.
        /// </summary>
        public const string CFJOBS = "CFJOBS";

        /// <summary>
        /// CFDDJ.
        /// </summary>
        public const string CFDDJ = "CFDDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFKCO", "CFKCO", JdeDataType.String, 10, true, true),
        new JdeField("CFDCT", "CFDCT", JdeDataType.String, 4, true, true),
        new JdeField("CFDOC", "CFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CFPNO", "CFPNO", JdeDataType.Numeric, null, true, true),
        new JdeField("CFATXA", "CFATXA", JdeDataType.Numeric),
        new JdeField("CFATXN", "CFATXN", JdeDataType.Numeric),
        new JdeField("CFAG", "CFAG", JdeDataType.Numeric),
        new JdeField("CFCTXA", "CFCTXA", JdeDataType.Numeric),
        new JdeField("CFCTXN", "CFCTXN", JdeDataType.Numeric),
        new JdeField("CFACR", "CFACR", JdeDataType.Numeric),
        new JdeField("CFSTA1", "CFSTA1", JdeDataType.Numeric),
        new JdeField("CFSTA2", "CFSTA2", JdeDataType.Numeric),
        new JdeField("CFSTA3", "CFSTA3", JdeDataType.Numeric),
        new JdeField("CFSTA4", "CFSTA4", JdeDataType.Numeric),
        new JdeField("CFSTA5", "CFSTA5", JdeDataType.Numeric),
        new JdeField("CFBA01", "CFBA01", JdeDataType.Numeric),
        new JdeField("CFBA02", "CFBA02", JdeDataType.Numeric),
        new JdeField("CFBA03", "CFBA03", JdeDataType.Numeric),
        new JdeField("CFBA04", "CFBA04", JdeDataType.Numeric),
        new JdeField("CFBA05", "CFBA05", JdeDataType.Numeric),
        new JdeField("CFURRF", "CFURRF", JdeDataType.String, 30),
        new JdeField("CFURCD", "CFURCD", JdeDataType.String, 4),
        new JdeField("CFURDT", "CFURDT", JdeDataType.Numeric),
        new JdeField("CFURAT", "CFURAT", JdeDataType.Numeric),
        new JdeField("CFURAB", "CFURAB", JdeDataType.Numeric),
        new JdeField("CFPID", "CFPID", JdeDataType.String, 20),
        new JdeField("CFUPMJ", "CFUPMJ", JdeDataType.Numeric),
        new JdeField("CFTDAY", "CFTDAY", JdeDataType.Numeric),
        new JdeField("CFJOBS", "CFJOBS", JdeDataType.Numeric),
        new JdeField("CFDDJ", "CFDDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A08_0", "Primary Key on CFKCO, CFDCT, CFDOC, CFPNO", new[] { "CFKCO", "CFDCT", "CFDOC", "CFPNO" }, isUnique: true, isPrimaryKey: true)
    };
}
