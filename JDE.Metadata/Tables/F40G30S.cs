using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G30S - .
/// </summary>
public class F40G30S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADJOBS.
        /// </summary>
        public const string ADJOBS = "ADJOBS";

        /// <summary>
        /// ADPEID.
        /// </summary>
        public const string ADPEID = "ADPEID";

        /// <summary>
        /// ADCTID.
        /// </summary>
        public const string ADCTID = "ADCTID";

        /// <summary>
        /// ADTCID.
        /// </summary>
        public const string ADTCID = "ADTCID";

        /// <summary>
        /// ADCNTRTID.
        /// </summary>
        public const string ADCNTRTID = "ADCNTRTID";

        /// <summary>
        /// ADCNTRTDID.
        /// </summary>
        public const string ADCNTRTDID = "ADCNTRTDID";

        /// <summary>
        /// ADADUKID.
        /// </summary>
        public const string ADADUKID = "ADADUKID";

        /// <summary>
        /// ADCNTRTCD.
        /// </summary>
        public const string ADCNTRTCD = "ADCNTRTCD";

        /// <summary>
        /// ADPYE.
        /// </summary>
        public const string ADPYE = "ADPYE";

        /// <summary>
        /// ADWVID.
        /// </summary>
        public const string ADWVID = "ADWVID";

        /// <summary>
        /// ADBLSCD2.
        /// </summary>
        public const string ADBLSCD2 = "ADBLSCD2";

        /// <summary>
        /// ADHARPER.
        /// </summary>
        public const string ADHARPER = "ADHARPER";

        /// <summary>
        /// ADHARSFX.
        /// </summary>
        public const string ADHARSFX = "ADHARSFX";

        /// <summary>
        /// ADANI.
        /// </summary>
        public const string ADANI = "ADANI";

        /// <summary>
        /// ADAMD.
        /// </summary>
        public const string ADAMD = "ADAMD";

        /// <summary>
        /// ADFAMD.
        /// </summary>
        public const string ADFAMD = "ADFAMD";

        /// <summary>
        /// ADCAMTPER.
        /// </summary>
        public const string ADCAMTPER = "ADCAMTPER";

        /// <summary>
        /// ADCNTRTUOM.
        /// </summary>
        public const string ADCNTRTUOM = "ADCNTRTUOM";

        /// <summary>
        /// ADASPD.
        /// </summary>
        public const string ADASPD = "ADASPD";

        /// <summary>
        /// ADCNTRTAMT.
        /// </summary>
        public const string ADCNTRTAMT = "ADCNTRTAMT";

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
        /// ADADEXDT.
        /// </summary>
        public const string ADADEXDT = "ADADEXDT";

        /// <summary>
        /// ADADEFFDT.
        /// </summary>
        public const string ADADEFFDT = "ADADEFFDT";

        /// <summary>
        /// ADADPER.
        /// </summary>
        public const string ADADPER = "ADADPER";

        /// <summary>
        /// ADCNTRTGN.
        /// </summary>
        public const string ADCNTRTGN = "ADCNTRTGN";

        /// <summary>
        /// ADADCRDC.
        /// </summary>
        public const string ADADCRDC = "ADADCRDC";
    }

    /// <inheritdoc />
    public override string TableName => "F40G30S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADJOBS", "ADJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ADPEID", "ADPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCTID", "ADCTID", JdeDataType.String, 30, true, true),
        new JdeField("ADTCID", "ADTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCNTRTID", "ADCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCNTRTDID", "ADCNTRTDID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADADUKID", "ADADUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADCNTRTCD", "ADCNTRTCD", JdeDataType.String, 24),
        new JdeField("ADPYE", "ADPYE", JdeDataType.Numeric),
        new JdeField("ADWVID", "ADWVID", JdeDataType.Numeric),
        new JdeField("ADBLSCD2", "ADBLSCD2", JdeDataType.String, 20),
        new JdeField("ADHARPER", "ADHARPER", JdeDataType.String, 12),
        new JdeField("ADHARSFX", "ADHARSFX", JdeDataType.String, 20),
        new JdeField("ADANI", "ADANI", JdeDataType.String, 58),
        new JdeField("ADAMD", "ADAMD", JdeDataType.Numeric),
        new JdeField("ADFAMD", "ADFAMD", JdeDataType.Numeric),
        new JdeField("ADCAMTPER", "ADCAMTPER", JdeDataType.Numeric),
        new JdeField("ADCNTRTUOM", "ADCNTRTUOM", JdeDataType.String, 4),
        new JdeField("ADASPD", "ADASPD", JdeDataType.String, 2),
        new JdeField("ADCNTRTAMT", "ADCNTRTAMT", JdeDataType.Numeric),
        new JdeField("ADSTDADNM", "ADSTDADNM", JdeDataType.String, 24),
        new JdeField("ADASSDDESC", "ADASSDDESC", JdeDataType.String, 60),
        new JdeField("ADADJTYPE", "ADADJTYPE", JdeDataType.String, 6),
        new JdeField("ADADEXDT", "ADADEXDT", JdeDataType.Date),
        new JdeField("ADADEFFDT", "ADADEFFDT", JdeDataType.Date),
        new JdeField("ADADPER", "ADADPER", JdeDataType.Numeric),
        new JdeField("ADCNTRTGN", "ADCNTRTGN", JdeDataType.String, 6),
        new JdeField("ADADCRDC", "ADADCRDC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G30S_0", "Primary Key on ADJOBS, ADPEID, ADCTID, ADTCID, ADCNTRTID, ADCNTRTDID, ADADUKID", new[] { "ADJOBS", "ADPEID", "ADCTID", "ADTCID", "ADCNTRTID", "ADCNTRTDID", "ADADUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G30S_2", "Index on ADJOBS, ADPEID, ADCTID, ADTCID, ADADUKID", new[] { "ADJOBS", "ADPEID", "ADCTID", "ADTCID", "ADADUKID" })
    };
}
