using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069096 - .
/// </summary>
public class F069096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YKCO.
        /// </summary>
        public const string YKCO = "YKCO";

        /// <summary>
        /// YKIGL.
        /// </summary>
        public const string YKIGL = "YKIGL";

        /// <summary>
        /// YKIAP.
        /// </summary>
        public const string YKIAP = "YKIAP";

        /// <summary>
        /// YKIAR.
        /// </summary>
        public const string YKIAR = "YKIAR";

        /// <summary>
        /// YKIPE.
        /// </summary>
        public const string YKIPE = "YKIPE";

        /// <summary>
        /// YKID.
        /// </summary>
        public const string YKID = "YKID";

        /// <summary>
        /// YKIW.
        /// </summary>
        public const string YKIW = "YKIW";

        /// <summary>
        /// YKIB.
        /// </summary>
        public const string YKIB = "YKIB";

        /// <summary>
        /// YKIH.
        /// </summary>
        public const string YKIH = "YKIH";

        /// <summary>
        /// YKSPP.
        /// </summary>
        public const string YKSPP = "YKSPP";

        /// <summary>
        /// YKSPB.
        /// </summary>
        public const string YKSPB = "YKSPB";

        /// <summary>
        /// YKAHTP.
        /// </summary>
        public const string YKAHTP = "YKAHTP";

        /// <summary>
        /// YKICRG.
        /// </summary>
        public const string YKICRG = "YKICRG";

        /// <summary>
        /// YKIARG.
        /// </summary>
        public const string YKIARG = "YKIARG";

        /// <summary>
        /// YKSUB.
        /// </summary>
        public const string YKSUB = "YKSUB";

        /// <summary>
        /// YKUSER.
        /// </summary>
        public const string YKUSER = "YKUSER";

        /// <summary>
        /// YKPID.
        /// </summary>
        public const string YKPID = "YKPID";

        /// <summary>
        /// YKUPMJ.
        /// </summary>
        public const string YKUPMJ = "YKUPMJ";

        /// <summary>
        /// YKEM.
        /// </summary>
        public const string YKEM = "YKEM";

        /// <summary>
        /// YKCCPR.
        /// </summary>
        public const string YKCCPR = "YKCCPR";

        /// <summary>
        /// YKPBFP.
        /// </summary>
        public const string YKPBFP = "YKPBFP";

        /// <summary>
        /// YKIIMG.
        /// </summary>
        public const string YKIIMG = "YKIIMG";

        /// <summary>
        /// YKFY.
        /// </summary>
        public const string YKFY = "YKFY";

        /// <summary>
        /// YKDNMN.
        /// </summary>
        public const string YKDNMN = "YKDNMN";

        /// <summary>
        /// YKALHR.
        /// </summary>
        public const string YKALHR = "YKALHR";

        /// <summary>
        /// YKSPR.
        /// </summary>
        public const string YKSPR = "YKSPR";

        /// <summary>
        /// YKBDRO.
        /// </summary>
        public const string YKBDRO = "YKBDRO";

        /// <summary>
        /// YKDOCK.
        /// </summary>
        public const string YKDOCK = "YKDOCK";

        /// <summary>
        /// YKDOCA.
        /// </summary>
        public const string YKDOCA = "YKDOCA";

        /// <summary>
        /// YKDOCH.
        /// </summary>
        public const string YKDOCH = "YKDOCH";

        /// <summary>
        /// YKTPRF.
        /// </summary>
        public const string YKTPRF = "YKTPRF";

        /// <summary>
        /// YKCPRF.
        /// </summary>
        public const string YKCPRF = "YKCPRF";

        /// <summary>
        /// YKCCTF.
        /// </summary>
        public const string YKCCTF = "YKCCTF";

        /// <summary>
        /// YKRTIN.
        /// </summary>
        public const string YKRTIN = "YKRTIN";

        /// <summary>
        /// YKCOIR.
        /// </summary>
        public const string YKCOIR = "YKCOIR";

        /// <summary>
        /// YKCORP.
        /// </summary>
        public const string YKCORP = "YKCORP";

        /// <summary>
        /// YKNCCD.
        /// </summary>
        public const string YKNCCD = "YKNCCD";

        /// <summary>
        /// YKAPMA.
        /// </summary>
        public const string YKAPMA = "YKAPMA";

        /// <summary>
        /// YKBCMA.
        /// </summary>
        public const string YKBCMA = "YKBCMA";

        /// <summary>
        /// YKARMA.
        /// </summary>
        public const string YKARMA = "YKARMA";

        /// <summary>
        /// YKDBAP.
        /// </summary>
        public const string YKDBAP = "YKDBAP";

        /// <summary>
        /// YKTXP.
        /// </summary>
        public const string YKTXP = "YKTXP";

        /// <summary>
        /// YKSUIC.
        /// </summary>
        public const string YKSUIC = "YKSUIC";

        /// <summary>
        /// YKCVDI.
        /// </summary>
        public const string YKCVDI = "YKCVDI";

        /// <summary>
        /// YKCCUF.
        /// </summary>
        public const string YKCCUF = "YKCCUF";

        /// <summary>
        /// YKCCDOW.
        /// </summary>
        public const string YKCCDOW = "YKCCDOW";

        /// <summary>
        /// YKTCO.
        /// </summary>
        public const string YKTCO = "YKTCO";

        /// <summary>
        /// YKPHIST.
        /// </summary>
        public const string YKPHIST = "YKPHIST";

        /// <summary>
        /// YKPCHKDT.
        /// </summary>
        public const string YKPCHKDT = "YKPCHKDT";

        /// <summary>
        /// YKPEBU.
        /// </summary>
        public const string YKPEBU = "YKPEBU";

        /// <summary>
        /// YKBPVD.
        /// </summary>
        public const string YKBPVD = "YKBPVD";
    }

    /// <inheritdoc />
    public override string TableName => "F069096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YKCO", "YKCO", JdeDataType.String, 10, true, true),
        new JdeField("YKIGL", "YKIGL", JdeDataType.String, 2),
        new JdeField("YKIAP", "YKIAP", JdeDataType.String, 2),
        new JdeField("YKIAR", "YKIAR", JdeDataType.String, 2),
        new JdeField("YKIPE", "YKIPE", JdeDataType.String, 2),
        new JdeField("YKID", "YKID", JdeDataType.Numeric),
        new JdeField("YKIW", "YKIW", JdeDataType.Numeric),
        new JdeField("YKIB", "YKIB", JdeDataType.Numeric),
        new JdeField("YKIH", "YKIH", JdeDataType.Numeric),
        new JdeField("YKSPP", "YKSPP", JdeDataType.String, 2),
        new JdeField("YKSPB", "YKSPB", JdeDataType.String, 2),
        new JdeField("YKAHTP", "YKAHTP", JdeDataType.String, 2),
        new JdeField("YKICRG", "YKICRG", JdeDataType.String, 2),
        new JdeField("YKIARG", "YKIARG", JdeDataType.String, 2),
        new JdeField("YKSUB", "YKSUB", JdeDataType.String, 16),
        new JdeField("YKUSER", "YKUSER", JdeDataType.String, 20),
        new JdeField("YKPID", "YKPID", JdeDataType.String, 20),
        new JdeField("YKUPMJ", "YKUPMJ", JdeDataType.Numeric),
        new JdeField("YKEM", "YKEM", JdeDataType.String, 2),
        new JdeField("YKCCPR", "YKCCPR", JdeDataType.String, 6),
        new JdeField("YKPBFP", "YKPBFP", JdeDataType.Numeric),
        new JdeField("YKIIMG", "YKIIMG", JdeDataType.String, 2),
        new JdeField("YKFY", "YKFY", JdeDataType.Numeric),
        new JdeField("YKDNMN", "YKDNMN", JdeDataType.Numeric),
        new JdeField("YKALHR", "YKALHR", JdeDataType.Numeric),
        new JdeField("YKSPR", "YKSPR", JdeDataType.String, 2),
        new JdeField("YKBDRO", "YKBDRO", JdeDataType.String, 2),
        new JdeField("YKDOCK", "YKDOCK", JdeDataType.Numeric),
        new JdeField("YKDOCA", "YKDOCA", JdeDataType.Numeric),
        new JdeField("YKDOCH", "YKDOCH", JdeDataType.Numeric),
        new JdeField("YKTPRF", "YKTPRF", JdeDataType.String, 2),
        new JdeField("YKCPRF", "YKCPRF", JdeDataType.String, 2),
        new JdeField("YKCCTF", "YKCCTF", JdeDataType.String, 2),
        new JdeField("YKRTIN", "YKRTIN", JdeDataType.Numeric),
        new JdeField("YKCOIR", "YKCOIR", JdeDataType.Numeric),
        new JdeField("YKCORP", "YKCORP", JdeDataType.String, 2),
        new JdeField("YKNCCD", "YKNCCD", JdeDataType.String, 2),
        new JdeField("YKAPMA", "YKAPMA", JdeDataType.String, 2),
        new JdeField("YKBCMA", "YKBCMA", JdeDataType.String, 2),
        new JdeField("YKARMA", "YKARMA", JdeDataType.String, 2),
        new JdeField("YKDBAP", "YKDBAP", JdeDataType.String, 2),
        new JdeField("YKTXP", "YKTXP", JdeDataType.String, 2),
        new JdeField("YKSUIC", "YKSUIC", JdeDataType.Numeric),
        new JdeField("YKCVDI", "YKCVDI", JdeDataType.String, 2),
        new JdeField("YKCCUF", "YKCCUF", JdeDataType.String, 2),
        new JdeField("YKCCDOW", "YKCCDOW", JdeDataType.String, 2),
        new JdeField("YKTCO", "YKTCO", JdeDataType.String, 2),
        new JdeField("YKPHIST", "YKPHIST", JdeDataType.String, 2),
        new JdeField("YKPCHKDT", "YKPCHKDT", JdeDataType.String, 2),
        new JdeField("YKPEBU", "YKPEBU", JdeDataType.String, 2),
        new JdeField("YKBPVD", "YKBPVD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069096_0", "Primary Key on YKCO", new[] { "YKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
