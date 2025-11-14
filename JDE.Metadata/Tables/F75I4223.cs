using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I4223 - .
/// </summary>
public class F75I4223 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDKCO.
        /// </summary>
        public const string SDKCO = "SDKCO";

        /// <summary>
        /// SDDOC.
        /// </summary>
        public const string SDDOC = "SDDOC";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDMCU.
        /// </summary>
        public const string SDMCU = "SDMCU";

        /// <summary>
        /// SDIVD.
        /// </summary>
        public const string SDIVD = "SDIVD";

        /// <summary>
        /// SDITM.
        /// </summary>
        public const string SDITM = "SDITM";

        /// <summary>
        /// SDLITM.
        /// </summary>
        public const string SDLITM = "SDLITM";

        /// <summary>
        /// SDTRQT.
        /// </summary>
        public const string SDTRQT = "SDTRQT";

        /// <summary>
        /// SDTRUM.
        /// </summary>
        public const string SDTRUM = "SDTRUM";

        /// <summary>
        /// SDSOQS.
        /// </summary>
        public const string SDSOQS = "SDSOQS";

        /// <summary>
        /// SDUOM4.
        /// </summary>
        public const string SDUOM4 = "SDUOM4";

        /// <summary>
        /// SDSTOP.
        /// </summary>
        public const string SDSTOP = "SDSTOP";

        /// <summary>
        /// SDZON.
        /// </summary>
        public const string SDZON = "SDZON";

        /// <summary>
        /// SDSRP1.
        /// </summary>
        public const string SDSRP1 = "SDSRP1";

        /// <summary>
        /// SDSRP2.
        /// </summary>
        public const string SDSRP2 = "SDSRP2";

        /// <summary>
        /// SDSRP3.
        /// </summary>
        public const string SDSRP3 = "SDSRP3";

        /// <summary>
        /// SDSRP4.
        /// </summary>
        public const string SDSRP4 = "SDSRP4";

        /// <summary>
        /// SDSRP5.
        /// </summary>
        public const string SDSRP5 = "SDSRP5";

        /// <summary>
        /// SDSRP0.
        /// </summary>
        public const string SDSRP0 = "SDSRP0";

        /// <summary>
        /// SDMATH01.
        /// </summary>
        public const string SDMATH01 = "SDMATH01";

        /// <summary>
        /// SDAST.
        /// </summary>
        public const string SDAST = "SDAST";

        /// <summary>
        /// SDFVTR.
        /// </summary>
        public const string SDFVTR = "SDFVTR";

        /// <summary>
        /// SDAN8.
        /// </summary>
        public const string SDAN8 = "SDAN8";

        /// <summary>
        /// SDSHAN.
        /// </summary>
        public const string SDSHAN = "SDSHAN";

        /// <summary>
        /// SDAEXP.
        /// </summary>
        public const string SDAEXP = "SDAEXP";

        /// <summary>
        /// SDYEXA.
        /// </summary>
        public const string SDYEXA = "SDYEXA";

        /// <summary>
        /// SDAREC.
        /// </summary>
        public const string SDAREC = "SDAREC";

        /// <summary>
        /// SDUPRC.
        /// </summary>
        public const string SDUPRC = "SDUPRC";

        /// <summary>
        /// SDFREC.
        /// </summary>
        public const string SDFREC = "SDFREC";

        /// <summary>
        /// SDAA.
        /// </summary>
        public const string SDAA = "SDAA";

        /// <summary>
        /// SDAAP.
        /// </summary>
        public const string SDAAP = "SDAAP";

        /// <summary>
        /// SDAFA1.
        /// </summary>
        public const string SDAFA1 = "SDAFA1";

        /// <summary>
        /// SDAA1.
        /// </summary>
        public const string SDAA1 = "SDAA1";

        /// <summary>
        /// SDFDADT1.
        /// </summary>
        public const string SDFDADT1 = "SDFDADT1";

        /// <summary>
        /// SDFDADT2.
        /// </summary>
        public const string SDFDADT2 = "SDFDADT2";

        /// <summary>
        /// SDFDADT3.
        /// </summary>
        public const string SDFDADT3 = "SDFDADT3";

        /// <summary>
        /// SDF1A.
        /// </summary>
        public const string SDF1A = "SDF1A";

        /// <summary>
        /// SDF2A.
        /// </summary>
        public const string SDF2A = "SDF2A";

        /// <summary>
        /// SDF3A.
        /// </summary>
        public const string SDF3A = "SDF3A";

        /// <summary>
        /// SDF4A.
        /// </summary>
        public const string SDF4A = "SDF4A";

        /// <summary>
        /// SDF5A.
        /// </summary>
        public const string SDF5A = "SDF5A";

        /// <summary>
        /// SDF6A.
        /// </summary>
        public const string SDF6A = "SDF6A";

        /// <summary>
        /// SDC1FU.
        /// </summary>
        public const string SDC1FU = "SDC1FU";

        /// <summary>
        /// SDC2FU.
        /// </summary>
        public const string SDC2FU = "SDC2FU";

        /// <summary>
        /// SDF1T.
        /// </summary>
        public const string SDF1T = "SDF1T";

        /// <summary>
        /// SDF2T.
        /// </summary>
        public const string SDF2T = "SDF2T";

        /// <summary>
        /// SDF3T.
        /// </summary>
        public const string SDF3T = "SDF3T";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDOLND.
        /// </summary>
        public const string SDOLND = "SDOLND";

        /// <summary>
        /// SDEF01.
        /// </summary>
        public const string SDEF01 = "SDEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I4223";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4),
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric),
        new JdeField("SDKCO", "SDKCO", JdeDataType.String, 10),
        new JdeField("SDDOC", "SDDOC", JdeDataType.Numeric),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDMCU", "SDMCU", JdeDataType.String, 24),
        new JdeField("SDIVD", "SDIVD", JdeDataType.Numeric),
        new JdeField("SDITM", "SDITM", JdeDataType.Numeric),
        new JdeField("SDLITM", "SDLITM", JdeDataType.String, 50),
        new JdeField("SDTRQT", "SDTRQT", JdeDataType.Numeric),
        new JdeField("SDTRUM", "SDTRUM", JdeDataType.String, 4),
        new JdeField("SDSOQS", "SDSOQS", JdeDataType.Numeric),
        new JdeField("SDUOM4", "SDUOM4", JdeDataType.String, 4),
        new JdeField("SDSTOP", "SDSTOP", JdeDataType.String, 6),
        new JdeField("SDZON", "SDZON", JdeDataType.String, 6),
        new JdeField("SDSRP1", "SDSRP1", JdeDataType.String, 6),
        new JdeField("SDSRP2", "SDSRP2", JdeDataType.String, 6),
        new JdeField("SDSRP3", "SDSRP3", JdeDataType.String, 6),
        new JdeField("SDSRP4", "SDSRP4", JdeDataType.String, 6),
        new JdeField("SDSRP5", "SDSRP5", JdeDataType.String, 6),
        new JdeField("SDSRP0", "SDSRP0", JdeDataType.String, 12),
        new JdeField("SDMATH01", "SDMATH01", JdeDataType.Numeric),
        new JdeField("SDAST", "SDAST", JdeDataType.String, 16),
        new JdeField("SDFVTR", "SDFVTR", JdeDataType.Numeric),
        new JdeField("SDAN8", "SDAN8", JdeDataType.Numeric),
        new JdeField("SDSHAN", "SDSHAN", JdeDataType.Numeric),
        new JdeField("SDAEXP", "SDAEXP", JdeDataType.Numeric),
        new JdeField("SDYEXA", "SDYEXA", JdeDataType.Numeric),
        new JdeField("SDAREC", "SDAREC", JdeDataType.Numeric),
        new JdeField("SDUPRC", "SDUPRC", JdeDataType.Numeric),
        new JdeField("SDFREC", "SDFREC", JdeDataType.Numeric),
        new JdeField("SDAA", "SDAA", JdeDataType.Numeric),
        new JdeField("SDAAP", "SDAAP", JdeDataType.Numeric),
        new JdeField("SDAFA1", "SDAFA1", JdeDataType.Numeric),
        new JdeField("SDAA1", "SDAA1", JdeDataType.Numeric),
        new JdeField("SDFDADT1", "SDFDADT1", JdeDataType.Numeric),
        new JdeField("SDFDADT2", "SDFDADT2", JdeDataType.Numeric),
        new JdeField("SDFDADT3", "SDFDADT3", JdeDataType.Numeric),
        new JdeField("SDF1A", "SDF1A", JdeDataType.Numeric),
        new JdeField("SDF2A", "SDF2A", JdeDataType.Numeric),
        new JdeField("SDF3A", "SDF3A", JdeDataType.Numeric),
        new JdeField("SDF4A", "SDF4A", JdeDataType.Numeric),
        new JdeField("SDF5A", "SDF5A", JdeDataType.Numeric),
        new JdeField("SDF6A", "SDF6A", JdeDataType.Numeric),
        new JdeField("SDC1FU", "SDC1FU", JdeDataType.String, 2),
        new JdeField("SDC2FU", "SDC2FU", JdeDataType.String, 2),
        new JdeField("SDF1T", "SDF1T", JdeDataType.String, 60),
        new JdeField("SDF2T", "SDF2T", JdeDataType.String, 60),
        new JdeField("SDF3T", "SDF3T", JdeDataType.String, 60),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20, true, true),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20, true, true),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20, true, true),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("SDOLND", "SDOLND", JdeDataType.Numeric, null, true, true),
        new JdeField("SDEF01", "SDEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I4223_0", "Primary Key on SDPID, SDUSER, SDJOBN, SDUPMJ, SDUPMT, SDOLND", new[] { "SDPID", "SDUSER", "SDJOBN", "SDUPMJ", "SDUPMT", "SDOLND" }, isUnique: true, isPrimaryKey: true)
    };
}
