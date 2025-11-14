using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C30 - .
/// </summary>
public class F43C30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADADUKID.
        /// </summary>
        public const string ADADUKID = "ADADUKID";

        /// <summary>
        /// ADSTDADNM.
        /// </summary>
        public const string ADSTDADNM = "ADSTDADNM";

        /// <summary>
        /// ADASSDDESC.
        /// </summary>
        public const string ADASSDDESC = "ADASSDDESC";

        /// <summary>
        /// ADADJTYPE.
        /// </summary>
        public const string ADADJTYPE = "ADADJTYPE";

        /// <summary>
        /// ADADEFFDT.
        /// </summary>
        public const string ADADEFFDT = "ADADEFFDT";

        /// <summary>
        /// ADADEXDT.
        /// </summary>
        public const string ADADEXDT = "ADADEXDT";

        /// <summary>
        /// ADADPER.
        /// </summary>
        public const string ADADPER = "ADADPER";

        /// <summary>
        /// ADCNTRTGN.
        /// </summary>
        public const string ADCNTRTGN = "ADCNTRTGN";

        /// <summary>
        /// ADCAMTPER.
        /// </summary>
        public const string ADCAMTPER = "ADCAMTPER";

        /// <summary>
        /// ADCNTRTUOM.
        /// </summary>
        public const string ADCNTRTUOM = "ADCNTRTUOM";

        /// <summary>
        /// ADCNTRTAMT.
        /// </summary>
        public const string ADCNTRTAMT = "ADCNTRTAMT";

        /// <summary>
        /// ADADCRDC.
        /// </summary>
        public const string ADADCRDC = "ADADCRDC";

        /// <summary>
        /// ADADCOMM.
        /// </summary>
        public const string ADADCOMM = "ADADCOMM";

        /// <summary>
        /// ADANI.
        /// </summary>
        public const string ADANI = "ADANI";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADTORG.
        /// </summary>
        public const string ADTORG = "ADTORG";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUUPMJ.
        /// </summary>
        public const string ADUUPMJ = "ADUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43C30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADADUKID", "ADADUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSTDADNM", "ADSTDADNM", JdeDataType.String, 24),
        new JdeField("ADASSDDESC", "ADASSDDESC", JdeDataType.String, 60),
        new JdeField("ADADJTYPE", "ADADJTYPE", JdeDataType.String, 6),
        new JdeField("ADADEFFDT", "ADADEFFDT", JdeDataType.Date),
        new JdeField("ADADEXDT", "ADADEXDT", JdeDataType.Date),
        new JdeField("ADADPER", "ADADPER", JdeDataType.Numeric),
        new JdeField("ADCNTRTGN", "ADCNTRTGN", JdeDataType.String, 6),
        new JdeField("ADCAMTPER", "ADCAMTPER", JdeDataType.Numeric),
        new JdeField("ADCNTRTUOM", "ADCNTRTUOM", JdeDataType.String, 4),
        new JdeField("ADCNTRTAMT", "ADCNTRTAMT", JdeDataType.Numeric),
        new JdeField("ADADCRDC", "ADADCRDC", JdeDataType.String, 6),
        new JdeField("ADADCOMM", "ADADCOMM", JdeDataType.String, 512),
        new JdeField("ADANI", "ADANI", JdeDataType.String, 58),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADTORG", "ADTORG", JdeDataType.String, 20),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUUPMJ", "ADUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C30_0", "Primary Key on ADADUKID", new[] { "ADADUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C30_2", "Index on ADSTDADNM, ADADUKID", new[] { "ADSTDADNM", "ADADUKID" })
    };
}
