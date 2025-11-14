using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R20 - .
/// </summary>
public class F40R20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRMCU.
        /// </summary>
        public const string DRMCU = "DRMCU";

        /// <summary>
        /// DRAN8.
        /// </summary>
        public const string DRAN8 = "DRAN8";

        /// <summary>
        /// DRSHAN.
        /// </summary>
        public const string DRSHAN = "DRSHAN";

        /// <summary>
        /// DRWKSDAY.
        /// </summary>
        public const string DRWKSDAY = "DRWKSDAY";

        /// <summary>
        /// DRAOLDDCR.
        /// </summary>
        public const string DRAOLDDCR = "DRAOLDDCR";

        /// <summary>
        /// DRREPCUMR.
        /// </summary>
        public const string DRREPCUMR = "DRREPCUMR";

        /// <summary>
        /// DRABFIRM.
        /// </summary>
        public const string DRABFIRM = "DRABFIRM";

        /// <summary>
        /// DRABPLAN.
        /// </summary>
        public const string DRABPLAN = "DRABPLAN";

        /// <summary>
        /// DRABPDSQ.
        /// </summary>
        public const string DRABPDSQ = "DRABPDSQ";

        /// <summary>
        /// DRSOVERCS.
        /// </summary>
        public const string DRSOVERCS = "DRSOVERCS";

        /// <summary>
        /// DRADJSDT.
        /// </summary>
        public const string DRADJSDT = "DRADJSDT";

        /// <summary>
        /// DRREPST.
        /// </summary>
        public const string DRREPST = "DRREPST";

        /// <summary>
        /// DRCUMADJS.
        /// </summary>
        public const string DRCUMADJS = "DRCUMADJS";

        /// <summary>
        /// DRPDAYCUMS.
        /// </summary>
        public const string DRPDAYCUMS = "DRPDAYCUMS";

        /// <summary>
        /// DRDECCUM.
        /// </summary>
        public const string DRDECCUM = "DRDECCUM";

        /// <summary>
        /// DRSOHOLD.
        /// </summary>
        public const string DRSOHOLD = "DRSOHOLD";

        /// <summary>
        /// DRADLNCUMS.
        /// </summary>
        public const string DRADLNCUMS = "DRADLNCUMS";

        /// <summary>
        /// DRTZSHP.
        /// </summary>
        public const string DRTZSHP = "DRTZSHP";

        /// <summary>
        /// DRTZDEL.
        /// </summary>
        public const string DRTZDEL = "DRTZDEL";

        /// <summary>
        /// DRURCD.
        /// </summary>
        public const string DRURCD = "DRURCD";

        /// <summary>
        /// DRURDT.
        /// </summary>
        public const string DRURDT = "DRURDT";

        /// <summary>
        /// DRURAT.
        /// </summary>
        public const string DRURAT = "DRURAT";

        /// <summary>
        /// DRURAB.
        /// </summary>
        public const string DRURAB = "DRURAB";

        /// <summary>
        /// DRURRF.
        /// </summary>
        public const string DRURRF = "DRURRF";

        /// <summary>
        /// DRUSER.
        /// </summary>
        public const string DRUSER = "DRUSER";

        /// <summary>
        /// DRPID.
        /// </summary>
        public const string DRPID = "DRPID";

        /// <summary>
        /// DRJOBN.
        /// </summary>
        public const string DRJOBN = "DRJOBN";

        /// <summary>
        /// DRUPMJ.
        /// </summary>
        public const string DRUPMJ = "DRUPMJ";

        /// <summary>
        /// DRTDAY.
        /// </summary>
        public const string DRTDAY = "DRTDAY";

        /// <summary>
        /// DRVSOHSTEX.
        /// </summary>
        public const string DRVSOHSTEX = "DRVSOHSTEX";

        /// <summary>
        /// DRRMVPSHP.
        /// </summary>
        public const string DRRMVPSHP = "DRRMVPSHP";

        /// <summary>
        /// DRPSI.
        /// </summary>
        public const string DRPSI = "DRPSI";

        /// <summary>
        /// DRQOO.
        /// </summary>
        public const string DRQOO = "DRQOO";
    }

    /// <inheritdoc />
    public override string TableName => "F40R20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRMCU", "DRMCU", JdeDataType.String, 24, true, true),
        new JdeField("DRAN8", "DRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DRSHAN", "DRSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("DRWKSDAY", "DRWKSDAY", JdeDataType.String, 2),
        new JdeField("DRAOLDDCR", "DRAOLDDCR", JdeDataType.String, 2),
        new JdeField("DRREPCUMR", "DRREPCUMR", JdeDataType.String, 2),
        new JdeField("DRABFIRM", "DRABFIRM", JdeDataType.String, 2),
        new JdeField("DRABPLAN", "DRABPLAN", JdeDataType.String, 2),
        new JdeField("DRABPDSQ", "DRABPDSQ", JdeDataType.String, 2),
        new JdeField("DRSOVERCS", "DRSOVERCS", JdeDataType.String, 50),
        new JdeField("DRADJSDT", "DRADJSDT", JdeDataType.String, 2),
        new JdeField("DRREPST", "DRREPST", JdeDataType.String, 2),
        new JdeField("DRCUMADJS", "DRCUMADJS", JdeDataType.String, 4),
        new JdeField("DRPDAYCUMS", "DRPDAYCUMS", JdeDataType.String, 2),
        new JdeField("DRDECCUM", "DRDECCUM", JdeDataType.String, 2),
        new JdeField("DRSOHOLD", "DRSOHOLD", JdeDataType.String, 2),
        new JdeField("DRADLNCUMS", "DRADLNCUMS", JdeDataType.String, 2),
        new JdeField("DRTZSHP", "DRTZSHP", JdeDataType.String, 2),
        new JdeField("DRTZDEL", "DRTZDEL", JdeDataType.String, 2),
        new JdeField("DRURCD", "DRURCD", JdeDataType.String, 4),
        new JdeField("DRURDT", "DRURDT", JdeDataType.Numeric),
        new JdeField("DRURAT", "DRURAT", JdeDataType.Numeric),
        new JdeField("DRURAB", "DRURAB", JdeDataType.Numeric),
        new JdeField("DRURRF", "DRURRF", JdeDataType.String, 30),
        new JdeField("DRUSER", "DRUSER", JdeDataType.String, 20),
        new JdeField("DRPID", "DRPID", JdeDataType.String, 20),
        new JdeField("DRJOBN", "DRJOBN", JdeDataType.String, 20),
        new JdeField("DRUPMJ", "DRUPMJ", JdeDataType.Numeric),
        new JdeField("DRTDAY", "DRTDAY", JdeDataType.Numeric),
        new JdeField("DRVSOHSTEX", "DRVSOHSTEX", JdeDataType.String, 20),
        new JdeField("DRRMVPSHP", "DRRMVPSHP", JdeDataType.String, 2),
        new JdeField("DRPSI", "DRPSI", JdeDataType.String, 2),
        new JdeField("DRQOO", "DRQOO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R20_0", "Primary Key on DRMCU, DRAN8, DRSHAN", new[] { "DRMCU", "DRAN8", "DRSHAN" }, isUnique: true, isPrimaryKey: true)
    };
}
