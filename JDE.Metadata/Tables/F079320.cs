using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F079320 - .
/// </summary>
public class F079320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WXTARA.
        /// </summary>
        public const string WXTARA = "WXTARA";

        /// <summary>
        /// WXPFRQ.
        /// </summary>
        public const string WXPFRQ = "WXPFRQ";

        /// <summary>
        /// WXEFTB.
        /// </summary>
        public const string WXEFTB = "WXEFTB";

        /// <summary>
        /// WXEFTE.
        /// </summary>
        public const string WXEFTE = "WXEFTE";

        /// <summary>
        /// WXEXP01.
        /// </summary>
        public const string WXEXP01 = "WXEXP01";

        /// <summary>
        /// WXEXP02.
        /// </summary>
        public const string WXEXP02 = "WXEXP02";

        /// <summary>
        /// WXEXP03.
        /// </summary>
        public const string WXEXP03 = "WXEXP03";

        /// <summary>
        /// WXEXP04.
        /// </summary>
        public const string WXEXP04 = "WXEXP04";

        /// <summary>
        /// WXEXP05.
        /// </summary>
        public const string WXEXP05 = "WXEXP05";

        /// <summary>
        /// WXEXP06.
        /// </summary>
        public const string WXEXP06 = "WXEXP06";

        /// <summary>
        /// WXEXP07.
        /// </summary>
        public const string WXEXP07 = "WXEXP07";

        /// <summary>
        /// WXEXP08.
        /// </summary>
        public const string WXEXP08 = "WXEXP08";

        /// <summary>
        /// WXEXP09.
        /// </summary>
        public const string WXEXP09 = "WXEXP09";

        /// <summary>
        /// WXEXP10.
        /// </summary>
        public const string WXEXP10 = "WXEXP10";

        /// <summary>
        /// WXSPCR01.
        /// </summary>
        public const string WXSPCR01 = "WXSPCR01";

        /// <summary>
        /// WXSPCR02.
        /// </summary>
        public const string WXSPCR02 = "WXSPCR02";

        /// <summary>
        /// WXSPCR03.
        /// </summary>
        public const string WXSPCR03 = "WXSPCR03";

        /// <summary>
        /// WXSPCR04.
        /// </summary>
        public const string WXSPCR04 = "WXSPCR04";

        /// <summary>
        /// WXSPST01.
        /// </summary>
        public const string WXSPST01 = "WXSPST01";

        /// <summary>
        /// WXSPST02.
        /// </summary>
        public const string WXSPST02 = "WXSPST02";

        /// <summary>
        /// WXSPST03.
        /// </summary>
        public const string WXSPST03 = "WXSPST03";

        /// <summary>
        /// WXSPST04.
        /// </summary>
        public const string WXSPST04 = "WXSPST04";

        /// <summary>
        /// WXSPDT01.
        /// </summary>
        public const string WXSPDT01 = "WXSPDT01";

        /// <summary>
        /// WXSPDT02.
        /// </summary>
        public const string WXSPDT02 = "WXSPDT02";

        /// <summary>
        /// WXSPDT03.
        /// </summary>
        public const string WXSPDT03 = "WXSPDT03";

        /// <summary>
        /// WXSPDT04.
        /// </summary>
        public const string WXSPDT04 = "WXSPDT04";

        /// <summary>
        /// WXSPNM01.
        /// </summary>
        public const string WXSPNM01 = "WXSPNM01";

        /// <summary>
        /// WXSPNM02.
        /// </summary>
        public const string WXSPNM02 = "WXSPNM02";

        /// <summary>
        /// WXSPNM03.
        /// </summary>
        public const string WXSPNM03 = "WXSPNM03";

        /// <summary>
        /// WXSPNM04.
        /// </summary>
        public const string WXSPNM04 = "WXSPNM04";

        /// <summary>
        /// WXUPMJ.
        /// </summary>
        public const string WXUPMJ = "WXUPMJ";

        /// <summary>
        /// WXUPMT.
        /// </summary>
        public const string WXUPMT = "WXUPMT";

        /// <summary>
        /// WXPID.
        /// </summary>
        public const string WXPID = "WXPID";

        /// <summary>
        /// WXJOBN.
        /// </summary>
        public const string WXJOBN = "WXJOBN";

        /// <summary>
        /// WXUSER.
        /// </summary>
        public const string WXUSER = "WXUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F079320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WXTARA", "WXTARA", JdeDataType.String, 20, true, true),
        new JdeField("WXPFRQ", "WXPFRQ", JdeDataType.String, 2, true, true),
        new JdeField("WXEFTB", "WXEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("WXEFTE", "WXEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("WXEXP01", "WXEXP01", JdeDataType.Numeric),
        new JdeField("WXEXP02", "WXEXP02", JdeDataType.Numeric),
        new JdeField("WXEXP03", "WXEXP03", JdeDataType.Numeric),
        new JdeField("WXEXP04", "WXEXP04", JdeDataType.Numeric),
        new JdeField("WXEXP05", "WXEXP05", JdeDataType.Numeric),
        new JdeField("WXEXP06", "WXEXP06", JdeDataType.Numeric),
        new JdeField("WXEXP07", "WXEXP07", JdeDataType.Numeric),
        new JdeField("WXEXP08", "WXEXP08", JdeDataType.Numeric),
        new JdeField("WXEXP09", "WXEXP09", JdeDataType.Numeric),
        new JdeField("WXEXP10", "WXEXP10", JdeDataType.Numeric),
        new JdeField("WXSPCR01", "WXSPCR01", JdeDataType.String, 2),
        new JdeField("WXSPCR02", "WXSPCR02", JdeDataType.String, 2),
        new JdeField("WXSPCR03", "WXSPCR03", JdeDataType.String, 2),
        new JdeField("WXSPCR04", "WXSPCR04", JdeDataType.String, 2),
        new JdeField("WXSPST01", "WXSPST01", JdeDataType.String, 60),
        new JdeField("WXSPST02", "WXSPST02", JdeDataType.String, 80),
        new JdeField("WXSPST03", "WXSPST03", JdeDataType.String, 100),
        new JdeField("WXSPST04", "WXSPST04", JdeDataType.String, 120),
        new JdeField("WXSPDT01", "WXSPDT01", JdeDataType.Numeric),
        new JdeField("WXSPDT02", "WXSPDT02", JdeDataType.Numeric),
        new JdeField("WXSPDT03", "WXSPDT03", JdeDataType.Numeric),
        new JdeField("WXSPDT04", "WXSPDT04", JdeDataType.Numeric),
        new JdeField("WXSPNM01", "WXSPNM01", JdeDataType.Numeric),
        new JdeField("WXSPNM02", "WXSPNM02", JdeDataType.Numeric),
        new JdeField("WXSPNM03", "WXSPNM03", JdeDataType.Numeric),
        new JdeField("WXSPNM04", "WXSPNM04", JdeDataType.Numeric),
        new JdeField("WXUPMJ", "WXUPMJ", JdeDataType.Numeric),
        new JdeField("WXUPMT", "WXUPMT", JdeDataType.Numeric),
        new JdeField("WXPID", "WXPID", JdeDataType.String, 20),
        new JdeField("WXJOBN", "WXJOBN", JdeDataType.String, 20),
        new JdeField("WXUSER", "WXUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F079320_0", "Primary Key on WXTARA, WXPFRQ, WXEFTB, WXEFTE", new[] { "WXTARA", "WXPFRQ", "WXEFTB", "WXEFTE" }, isUnique: true, isPrimaryKey: true)
    };
}
