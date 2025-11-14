using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31200 - .
/// </summary>
public class FF31200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCPRODF31.
        /// </summary>
        public const string PCPRODF31 = "PCPRODF31";

        /// <summary>
        /// PCTRSID.
        /// </summary>
        public const string PCTRSID = "PCTRSID";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCLITM.
        /// </summary>
        public const string PCLITM = "PCLITM";

        /// <summary>
        /// PCAITM.
        /// </summary>
        public const string PCAITM = "PCAITM";

        /// <summary>
        /// PCCOST.
        /// </summary>
        public const string PCCOST = "PCCOST";

        /// <summary>
        /// PCPART.
        /// </summary>
        public const string PCPART = "PCPART";

        /// <summary>
        /// PCOPUN.
        /// </summary>
        public const string PCOPUN = "PCOPUN";

        /// <summary>
        /// PCOPATD8.
        /// </summary>
        public const string PCOPATD8 = "PCOPATD8";

        /// <summary>
        /// PCCCCU.
        /// </summary>
        public const string PCCCCU = "PCCCCU";

        /// <summary>
        /// PCCCCAD8.
        /// </summary>
        public const string PCCCCAD8 = "PCCCCAD8";

        /// <summary>
        /// PCPLUN.
        /// </summary>
        public const string PCPLUN = "PCPLUN";

        /// <summary>
        /// PCPLATD8.
        /// </summary>
        public const string PCPLATD8 = "PCPLATD8";

        /// <summary>
        /// PCCLUN.
        /// </summary>
        public const string PCCLUN = "PCCLUN";

        /// <summary>
        /// PCCLATD8.
        /// </summary>
        public const string PCCLATD8 = "PCCLATD8";

        /// <summary>
        /// PCCPUN.
        /// </summary>
        public const string PCCPUN = "PCCPUN";

        /// <summary>
        /// PCCPATD8.
        /// </summary>
        public const string PCCPATD8 = "PCCPATD8";

        /// <summary>
        /// PCSLUN.
        /// </summary>
        public const string PCSLUN = "PCSLUN";

        /// <summary>
        /// PCSLATD8.
        /// </summary>
        public const string PCSLATD8 = "PCSLATD8";

        /// <summary>
        /// PCUOM.
        /// </summary>
        public const string PCUOM = "PCUOM";

        /// <summary>
        /// PCENGVD8.
        /// </summary>
        public const string PCENGVD8 = "PCENGVD8";

        /// <summary>
        /// PCPLNVD8.
        /// </summary>
        public const string PCPLNVD8 = "PCPLNVD8";

        /// <summary>
        /// PCACTVD8.
        /// </summary>
        public const string PCACTVD8 = "PCACTVD8";

        /// <summary>
        /// PCOTHVD8.
        /// </summary>
        public const string PCOTHVD8 = "PCOTHVD8";

        /// <summary>
        /// PCNETVD8.
        /// </summary>
        public const string PCNETVD8 = "PCNETVD8";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCUURDT.
        /// </summary>
        public const string PCUURDT = "PCUURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";

        /// <summary>
        /// PCMKEY.
        /// </summary>
        public const string PCMKEY = "PCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "FF31200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCPRODF31", "PCPRODF31", JdeDataType.Numeric, null, true, true),
        new JdeField("PCTRSID", "PCTRSID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCLITM", "PCLITM", JdeDataType.String, 50),
        new JdeField("PCAITM", "PCAITM", JdeDataType.String, 50),
        new JdeField("PCCOST", "PCCOST", JdeDataType.String, 6, true, true),
        new JdeField("PCPART", "PCPART", JdeDataType.String, 2, true, true),
        new JdeField("PCOPUN", "PCOPUN", JdeDataType.Numeric),
        new JdeField("PCOPATD8", "PCOPATD8", JdeDataType.Numeric),
        new JdeField("PCCCCU", "PCCCCU", JdeDataType.Numeric),
        new JdeField("PCCCCAD8", "PCCCCAD8", JdeDataType.Numeric),
        new JdeField("PCPLUN", "PCPLUN", JdeDataType.Numeric),
        new JdeField("PCPLATD8", "PCPLATD8", JdeDataType.Numeric),
        new JdeField("PCCLUN", "PCCLUN", JdeDataType.Numeric),
        new JdeField("PCCLATD8", "PCCLATD8", JdeDataType.Numeric),
        new JdeField("PCCPUN", "PCCPUN", JdeDataType.Numeric),
        new JdeField("PCCPATD8", "PCCPATD8", JdeDataType.Numeric),
        new JdeField("PCSLUN", "PCSLUN", JdeDataType.Numeric),
        new JdeField("PCSLATD8", "PCSLATD8", JdeDataType.Numeric),
        new JdeField("PCUOM", "PCUOM", JdeDataType.String, 4),
        new JdeField("PCENGVD8", "PCENGVD8", JdeDataType.Numeric),
        new JdeField("PCPLNVD8", "PCPLNVD8", JdeDataType.Numeric),
        new JdeField("PCACTVD8", "PCACTVD8", JdeDataType.Numeric),
        new JdeField("PCOTHVD8", "PCOTHVD8", JdeDataType.Numeric),
        new JdeField("PCNETVD8", "PCNETVD8", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCUURDT", "PCUURDT", JdeDataType.Date),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric),
        new JdeField("PCMKEY", "PCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31200_0", "Primary Key on PCPRODF31, PCTRSID, PCITM, PCCOST, PCPART", new[] { "PCPRODF31", "PCTRSID", "PCITM", "PCCOST", "PCPART" }, isUnique: true, isPrimaryKey: true)
    };
}
