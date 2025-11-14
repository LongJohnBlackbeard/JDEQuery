using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q50 - .
/// </summary>
public class F43Q50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AVEVNU.
        /// </summary>
        public const string AVEVNU = "AVEVNU";

        /// <summary>
        /// AVDCTO.
        /// </summary>
        public const string AVDCTO = "AVDCTO";

        /// <summary>
        /// AVKCOO.
        /// </summary>
        public const string AVKCOO = "AVKCOO";

        /// <summary>
        /// AVAN8.
        /// </summary>
        public const string AVAN8 = "AVAN8";

        /// <summary>
        /// AVBIDNUM.
        /// </summary>
        public const string AVBIDNUM = "AVBIDNUM";

        /// <summary>
        /// AVAWARDNUM.
        /// </summary>
        public const string AVAWARDNUM = "AVAWARDNUM";

        /// <summary>
        /// AVEVFT.
        /// </summary>
        public const string AVEVFT = "AVEVFT";

        /// <summary>
        /// AVALPH.
        /// </summary>
        public const string AVALPH = "AVALPH";

        /// <summary>
        /// AVCRDC.
        /// </summary>
        public const string AVCRDC = "AVCRDC";

        /// <summary>
        /// AVCRCD.
        /// </summary>
        public const string AVCRCD = "AVCRCD";

        /// <summary>
        /// AVAWARDCUR.
        /// </summary>
        public const string AVAWARDCUR = "AVAWARDCUR";

        /// <summary>
        /// AVBSTS01.
        /// </summary>
        public const string AVBSTS01 = "AVBSTS01";

        /// <summary>
        /// AVDOCO.
        /// </summary>
        public const string AVDOCO = "AVDOCO";

        /// <summary>
        /// AVRCTO.
        /// </summary>
        public const string AVRCTO = "AVRCTO";

        /// <summary>
        /// AVRKCO.
        /// </summary>
        public const string AVRKCO = "AVRKCO";

        /// <summary>
        /// AVMCU.
        /// </summary>
        public const string AVMCU = "AVMCU";

        /// <summary>
        /// AVALKY.
        /// </summary>
        public const string AVALKY = "AVALKY";

        /// <summary>
        /// AVSHAN.
        /// </summary>
        public const string AVSHAN = "AVSHAN";

        /// <summary>
        /// AVCBORPO.
        /// </summary>
        public const string AVCBORPO = "AVCBORPO";

        /// <summary>
        /// AVHBQS.
        /// </summary>
        public const string AVHBQS = "AVHBQS";

        /// <summary>
        /// AVTLBQS.
        /// </summary>
        public const string AVTLBQS = "AVTLBQS";

        /// <summary>
        /// AVAWARDACT.
        /// </summary>
        public const string AVAWARDACT = "AVAWARDACT";

        /// <summary>
        /// AVRCD.
        /// </summary>
        public const string AVRCD = "AVRCD";

        /// <summary>
        /// AVPCAW.
        /// </summary>
        public const string AVPCAW = "AVPCAW";

        /// <summary>
        /// AVPTC.
        /// </summary>
        public const string AVPTC = "AVPTC";

        /// <summary>
        /// AVURCD.
        /// </summary>
        public const string AVURCD = "AVURCD";

        /// <summary>
        /// AVURDT.
        /// </summary>
        public const string AVURDT = "AVURDT";

        /// <summary>
        /// AVURAT.
        /// </summary>
        public const string AVURAT = "AVURAT";

        /// <summary>
        /// AVURAB.
        /// </summary>
        public const string AVURAB = "AVURAB";

        /// <summary>
        /// AVURRF.
        /// </summary>
        public const string AVURRF = "AVURRF";

        /// <summary>
        /// AVTORG.
        /// </summary>
        public const string AVTORG = "AVTORG";

        /// <summary>
        /// AVUSER.
        /// </summary>
        public const string AVUSER = "AVUSER";

        /// <summary>
        /// AVPID.
        /// </summary>
        public const string AVPID = "AVPID";

        /// <summary>
        /// AVJOBN.
        /// </summary>
        public const string AVJOBN = "AVJOBN";

        /// <summary>
        /// AVUPMJ.
        /// </summary>
        public const string AVUPMJ = "AVUPMJ";

        /// <summary>
        /// AVTDAY.
        /// </summary>
        public const string AVTDAY = "AVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AVEVNU", "AVEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("AVDCTO", "AVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AVKCOO", "AVKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AVAN8", "AVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AVBIDNUM", "AVBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("AVAWARDNUM", "AVAWARDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("AVEVFT", "AVEVFT", JdeDataType.String, 6),
        new JdeField("AVALPH", "AVALPH", JdeDataType.String, 80),
        new JdeField("AVCRDC", "AVCRDC", JdeDataType.String, 6),
        new JdeField("AVCRCD", "AVCRCD", JdeDataType.String, 6),
        new JdeField("AVAWARDCUR", "AVAWARDCUR", JdeDataType.String, 4),
        new JdeField("AVBSTS01", "AVBSTS01", JdeDataType.String, 4),
        new JdeField("AVDOCO", "AVDOCO", JdeDataType.Numeric),
        new JdeField("AVRCTO", "AVRCTO", JdeDataType.String, 4),
        new JdeField("AVRKCO", "AVRKCO", JdeDataType.String, 10),
        new JdeField("AVMCU", "AVMCU", JdeDataType.String, 24),
        new JdeField("AVALKY", "AVALKY", JdeDataType.String, 40),
        new JdeField("AVSHAN", "AVSHAN", JdeDataType.Numeric),
        new JdeField("AVCBORPO", "AVCBORPO", JdeDataType.String, 4),
        new JdeField("AVHBQS", "AVHBQS", JdeDataType.Numeric),
        new JdeField("AVTLBQS", "AVTLBQS", JdeDataType.Numeric),
        new JdeField("AVAWARDACT", "AVAWARDACT", JdeDataType.String, 4),
        new JdeField("AVRCD", "AVRCD", JdeDataType.String, 6),
        new JdeField("AVPCAW", "AVPCAW", JdeDataType.Numeric),
        new JdeField("AVPTC", "AVPTC", JdeDataType.String, 6),
        new JdeField("AVURCD", "AVURCD", JdeDataType.String, 4),
        new JdeField("AVURDT", "AVURDT", JdeDataType.Numeric),
        new JdeField("AVURAT", "AVURAT", JdeDataType.Numeric),
        new JdeField("AVURAB", "AVURAB", JdeDataType.Numeric),
        new JdeField("AVURRF", "AVURRF", JdeDataType.String, 30),
        new JdeField("AVTORG", "AVTORG", JdeDataType.String, 20),
        new JdeField("AVUSER", "AVUSER", JdeDataType.String, 20),
        new JdeField("AVPID", "AVPID", JdeDataType.String, 20),
        new JdeField("AVJOBN", "AVJOBN", JdeDataType.String, 20),
        new JdeField("AVUPMJ", "AVUPMJ", JdeDataType.Numeric),
        new JdeField("AVTDAY", "AVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q50_0", "Primary Key on AVEVNU, AVDCTO, AVKCOO, AVAN8, AVBIDNUM, AVAWARDNUM", new[] { "AVEVNU", "AVDCTO", "AVKCOO", "AVAN8", "AVBIDNUM", "AVAWARDNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q50_2", "Index on AVDOCO, AVRCTO, AVRKCO", new[] { "AVDOCO", "AVRCTO", "AVRKCO" })
    };
}
