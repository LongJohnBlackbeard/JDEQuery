using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3293 - .
/// </summary>
public class F3293 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KYMCU.
        /// </summary>
        public const string KYMCU = "KYMCU";

        /// <summary>
        /// KYKIT.
        /// </summary>
        public const string KYKIT = "KYKIT";

        /// <summary>
        /// KYLITM.
        /// </summary>
        public const string KYLITM = "KYLITM";

        /// <summary>
        /// KYAITM.
        /// </summary>
        public const string KYAITM = "KYAITM";

        /// <summary>
        /// KYATOT.
        /// </summary>
        public const string KYATOT = "KYATOT";

        /// <summary>
        /// KYATO#.
        /// </summary>
        public const string KYATO_ = "KYATO#";

        /// <summary>
        /// KYATOS.
        /// </summary>
        public const string KYATOS = "KYATOS";

        /// <summary>
        /// KYITM.
        /// </summary>
        public const string KYITM = "KYITM";

        /// <summary>
        /// KYCMCU.
        /// </summary>
        public const string KYCMCU = "KYCMCU";

        /// <summary>
        /// KYDSC1.
        /// </summary>
        public const string KYDSC1 = "KYDSC1";

        /// <summary>
        /// KYAO.
        /// </summary>
        public const string KYAO = "KYAO";

        /// <summary>
        /// KYAO5B.
        /// </summary>
        public const string KYAO5B = "KYAO5B";

        /// <summary>
        /// KYAO5E.
        /// </summary>
        public const string KYAO5E = "KYAO5E";

        /// <summary>
        /// KYPEL.
        /// </summary>
        public const string KYPEL = "KYPEL";

        /// <summary>
        /// KYPSIN.
        /// </summary>
        public const string KYPSIN = "KYPSIN";

        /// <summary>
        /// KYEMCU.
        /// </summary>
        public const string KYEMCU = "KYEMCU";

        /// <summary>
        /// KYVALR.
        /// </summary>
        public const string KYVALR = "KYVALR";

        /// <summary>
        /// KYATIV.
        /// </summary>
        public const string KYATIV = "KYATIV";

        /// <summary>
        /// KYCEL.
        /// </summary>
        public const string KYCEL = "KYCEL";

        /// <summary>
        /// KYOPSQ.
        /// </summary>
        public const string KYOPSQ = "KYOPSQ";

        /// <summary>
        /// KYUPAX.
        /// </summary>
        public const string KYUPAX = "KYUPAX";

        /// <summary>
        /// KYCST1.
        /// </summary>
        public const string KYCST1 = "KYCST1";

        /// <summary>
        /// KYLNTY.
        /// </summary>
        public const string KYLNTY = "KYLNTY";

        /// <summary>
        /// KYQNTY.
        /// </summary>
        public const string KYQNTY = "KYQNTY";

        /// <summary>
        /// KYUM.
        /// </summary>
        public const string KYUM = "KYUM";

        /// <summary>
        /// KYFOVQ.
        /// </summary>
        public const string KYFOVQ = "KYFOVQ";

        /// <summary>
        /// KYCQS.
        /// </summary>
        public const string KYCQS = "KYCQS";

        /// <summary>
        /// KYWADL.
        /// </summary>
        public const string KYWADL = "KYWADL";

        /// <summary>
        /// KYCIDN.
        /// </summary>
        public const string KYCIDN = "KYCIDN";

        /// <summary>
        /// KYITC.
        /// </summary>
        public const string KYITC = "KYITC";

        /// <summary>
        /// KYLOVD.
        /// </summary>
        public const string KYLOVD = "KYLOVD";

        /// <summary>
        /// KYBSEQ.
        /// </summary>
        public const string KYBSEQ = "KYBSEQ";

        /// <summary>
        /// KYSCRP.
        /// </summary>
        public const string KYSCRP = "KYSCRP";

        /// <summary>
        /// KYEFFF.
        /// </summary>
        public const string KYEFFF = "KYEFFF";

        /// <summary>
        /// KYEFFT.
        /// </summary>
        public const string KYEFFT = "KYEFFT";

        /// <summary>
        /// KYEPGM.
        /// </summary>
        public const string KYEPGM = "KYEPGM";

        /// <summary>
        /// KYDERC.
        /// </summary>
        public const string KYDERC = "KYDERC";

        /// <summary>
        /// KYDERP.
        /// </summary>
        public const string KYDERP = "KYDERP";

        /// <summary>
        /// KYFVTY.
        /// </summary>
        public const string KYFVTY = "KYFVTY";

        /// <summary>
        /// KYSO03.
        /// </summary>
        public const string KYSO03 = "KYSO03";

        /// <summary>
        /// KYPRU.
        /// </summary>
        public const string KYPRU = "KYPRU";

        /// <summary>
        /// KYTBLC.
        /// </summary>
        public const string KYTBLC = "KYTBLC";

        /// <summary>
        /// KYCIA.
        /// </summary>
        public const string KYCIA = "KYCIA";

        /// <summary>
        /// KYUKID.
        /// </summary>
        public const string KYUKID = "KYUKID";

        /// <summary>
        /// KYURCD.
        /// </summary>
        public const string KYURCD = "KYURCD";

        /// <summary>
        /// KYURDT.
        /// </summary>
        public const string KYURDT = "KYURDT";

        /// <summary>
        /// KYURAT.
        /// </summary>
        public const string KYURAT = "KYURAT";

        /// <summary>
        /// KYURAB.
        /// </summary>
        public const string KYURAB = "KYURAB";

        /// <summary>
        /// KYURRF.
        /// </summary>
        public const string KYURRF = "KYURRF";

        /// <summary>
        /// KYUSER.
        /// </summary>
        public const string KYUSER = "KYUSER";

        /// <summary>
        /// KYPID.
        /// </summary>
        public const string KYPID = "KYPID";

        /// <summary>
        /// KYJOBN.
        /// </summary>
        public const string KYJOBN = "KYJOBN";

        /// <summary>
        /// KYUPMJ.
        /// </summary>
        public const string KYUPMJ = "KYUPMJ";

        /// <summary>
        /// KYTDAY.
        /// </summary>
        public const string KYTDAY = "KYTDAY";

        /// <summary>
        /// KYCIALEFT.
        /// </summary>
        public const string KYCIALEFT = "KYCIALEFT";

        /// <summary>
        /// KYITMRIGHT.
        /// </summary>
        public const string KYITMRIGHT = "KYITMRIGHT";

        /// <summary>
        /// KYMCURIGHT.
        /// </summary>
        public const string KYMCURIGHT = "KYMCURIGHT";

        /// <summary>
        /// KYCIARIGHT.
        /// </summary>
        public const string KYCIARIGHT = "KYCIARIGHT";

        /// <summary>
        /// KYAN8.
        /// </summary>
        public const string KYAN8 = "KYAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F3293";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KYMCU", "KYMCU", JdeDataType.String, 24, true, true),
        new JdeField("KYKIT", "KYKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KYLITM", "KYLITM", JdeDataType.String, 50),
        new JdeField("KYAITM", "KYAITM", JdeDataType.String, 50),
        new JdeField("KYATOT", "KYATOT", JdeDataType.String, 2, true, true),
        new JdeField("KYATO#", "KYATO#", JdeDataType.Numeric, null, true, true),
        new JdeField("KYATOS", "KYATOS", JdeDataType.Numeric, null, true, true),
        new JdeField("KYITM", "KYITM", JdeDataType.Numeric),
        new JdeField("KYCMCU", "KYCMCU", JdeDataType.String, 24),
        new JdeField("KYDSC1", "KYDSC1", JdeDataType.String, 60),
        new JdeField("KYAO", "KYAO", JdeDataType.String, 2),
        new JdeField("KYAO5B", "KYAO5B", JdeDataType.String, 8),
        new JdeField("KYAO5E", "KYAO5E", JdeDataType.String, 8),
        new JdeField("KYPEL", "KYPEL", JdeDataType.Numeric),
        new JdeField("KYPSIN", "KYPSIN", JdeDataType.Numeric),
        new JdeField("KYEMCU", "KYEMCU", JdeDataType.String, 24),
        new JdeField("KYVALR", "KYVALR", JdeDataType.String, 4),
        new JdeField("KYATIV", "KYATIV", JdeDataType.String, 80),
        new JdeField("KYCEL", "KYCEL", JdeDataType.Numeric),
        new JdeField("KYOPSQ", "KYOPSQ", JdeDataType.Numeric),
        new JdeField("KYUPAX", "KYUPAX", JdeDataType.Numeric),
        new JdeField("KYCST1", "KYCST1", JdeDataType.Numeric),
        new JdeField("KYLNTY", "KYLNTY", JdeDataType.String, 4),
        new JdeField("KYQNTY", "KYQNTY", JdeDataType.Numeric),
        new JdeField("KYUM", "KYUM", JdeDataType.String, 4),
        new JdeField("KYFOVQ", "KYFOVQ", JdeDataType.String, 2),
        new JdeField("KYCQS", "KYCQS", JdeDataType.String, 2),
        new JdeField("KYWADL", "KYWADL", JdeDataType.String, 2),
        new JdeField("KYCIDN", "KYCIDN", JdeDataType.String, 2),
        new JdeField("KYITC", "KYITC", JdeDataType.String, 2),
        new JdeField("KYLOVD", "KYLOVD", JdeDataType.Numeric),
        new JdeField("KYBSEQ", "KYBSEQ", JdeDataType.Numeric),
        new JdeField("KYSCRP", "KYSCRP", JdeDataType.Numeric),
        new JdeField("KYEFFF", "KYEFFF", JdeDataType.Numeric),
        new JdeField("KYEFFT", "KYEFFT", JdeDataType.Numeric),
        new JdeField("KYEPGM", "KYEPGM", JdeDataType.String, 20),
        new JdeField("KYDERC", "KYDERC", JdeDataType.String, 160),
        new JdeField("KYDERP", "KYDERP", JdeDataType.String, 80),
        new JdeField("KYFVTY", "KYFVTY", JdeDataType.String, 2),
        new JdeField("KYSO03", "KYSO03", JdeDataType.String, 2),
        new JdeField("KYPRU", "KYPRU", JdeDataType.String, 2),
        new JdeField("KYTBLC", "KYTBLC", JdeDataType.String, 20),
        new JdeField("KYCIA", "KYCIA", JdeDataType.String, 20),
        new JdeField("KYUKID", "KYUKID", JdeDataType.Numeric),
        new JdeField("KYURCD", "KYURCD", JdeDataType.String, 4),
        new JdeField("KYURDT", "KYURDT", JdeDataType.Numeric),
        new JdeField("KYURAT", "KYURAT", JdeDataType.Numeric),
        new JdeField("KYURAB", "KYURAB", JdeDataType.Numeric),
        new JdeField("KYURRF", "KYURRF", JdeDataType.String, 30),
        new JdeField("KYUSER", "KYUSER", JdeDataType.String, 20),
        new JdeField("KYPID", "KYPID", JdeDataType.String, 20),
        new JdeField("KYJOBN", "KYJOBN", JdeDataType.String, 20),
        new JdeField("KYUPMJ", "KYUPMJ", JdeDataType.Numeric),
        new JdeField("KYTDAY", "KYTDAY", JdeDataType.Numeric),
        new JdeField("KYCIALEFT", "KYCIALEFT", JdeDataType.String, 20),
        new JdeField("KYITMRIGHT", "KYITMRIGHT", JdeDataType.Numeric),
        new JdeField("KYMCURIGHT", "KYMCURIGHT", JdeDataType.String, 24),
        new JdeField("KYCIARIGHT", "KYCIARIGHT", JdeDataType.String, 20),
        new JdeField("KYAN8", "KYAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3293_0", "Primary Key on KYKIT, KYMCU, KYATOT, KYATO#, KYATOS", new[] { "KYKIT", "KYMCU", "KYATOT", "KYATO#", "KYATOS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3293_2", "Index on KYKIT, KYMCU, KYPEL", new[] { "KYKIT", "KYMCU", "KYPEL" }),
        new JdeIndex("F3293_3", "Index on KYATOT, KYITM, KYCMCU", new[] { "KYATOT", "KYITM", "KYCMCU" }),
        new JdeIndex("F3293_4", "Index on KYATOT, KYKIT, KYPEL, KYMCU", new[] { "KYATOT", "KYKIT", "KYPEL", "KYMCU" }),
        new JdeIndex("F3293_5", "Index on KYATOT, KYPSIN, KYPEL, KYEMCU", new[] { "KYATOT", "KYPSIN", "KYPEL", "KYEMCU" }),
        new JdeIndex("F3293_6", "Index on KYPSIN, KYEMCU, KYPEL", new[] { "KYPSIN", "KYEMCU", "KYPEL" }),
        new JdeIndex("F3293_7", "Index on KYMCU, KYKIT, KYATOT, SYS_NC00060$, SYS_NC00061$", new[] { "KYMCU", "KYKIT", "KYATOT", "SYS_NC00060$", "SYS_NC00061$" }),
        new JdeIndex("F3293_8", "Index on KYAN8, KYKIT, KYMCU", new[] { "KYAN8", "KYKIT", "KYMCU" }),
        new JdeIndex("F3293_9", "Index on KYCIA, KYITM, KYCMCU", new[] { "KYCIA", "KYITM", "KYCMCU" })
    };
}
