using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L11 - .
/// </summary>
public class F46L11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDLPNU.
        /// </summary>
        public const string IDLPNU = "IDLPNU";

        /// <summary>
        /// IDITM.
        /// </summary>
        public const string IDITM = "IDITM";

        /// <summary>
        /// IDLOTN.
        /// </summary>
        public const string IDLOTN = "IDLOTN";

        /// <summary>
        /// IDMCU.
        /// </summary>
        public const string IDMCU = "IDMCU";

        /// <summary>
        /// IDLOCN.
        /// </summary>
        public const string IDLOCN = "IDLOCN";

        /// <summary>
        /// IDPQOR.
        /// </summary>
        public const string IDPQOR = "IDPQOR";

        /// <summary>
        /// IDUOM1.
        /// </summary>
        public const string IDUOM1 = "IDUOM1";

        /// <summary>
        /// IDDQTY.
        /// </summary>
        public const string IDDQTY = "IDDQTY";

        /// <summary>
        /// IDUOM2.
        /// </summary>
        public const string IDUOM2 = "IDUOM2";

        /// <summary>
        /// IDGWEI.
        /// </summary>
        public const string IDGWEI = "IDGWEI";

        /// <summary>
        /// IDGWUM.
        /// </summary>
        public const string IDGWUM = "IDGWUM";

        /// <summary>
        /// IDGCUB.
        /// </summary>
        public const string IDGCUB = "IDGCUB";

        /// <summary>
        /// IDWIUM.
        /// </summary>
        public const string IDWIUM = "IDWIUM";

        /// <summary>
        /// IDLPNDC.
        /// </summary>
        public const string IDLPNDC = "IDLPNDC";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDPID.
        /// </summary>
        public const string IDPID = "IDPID";

        /// <summary>
        /// IDMKEY.
        /// </summary>
        public const string IDMKEY = "IDMKEY";

        /// <summary>
        /// IDURCD.
        /// </summary>
        public const string IDURCD = "IDURCD";

        /// <summary>
        /// IDURDT.
        /// </summary>
        public const string IDURDT = "IDURDT";

        /// <summary>
        /// IDURAB.
        /// </summary>
        public const string IDURAB = "IDURAB";

        /// <summary>
        /// IDURRF.
        /// </summary>
        public const string IDURRF = "IDURRF";

        /// <summary>
        /// IDRCDJ.
        /// </summary>
        public const string IDRCDJ = "IDRCDJ";

        /// <summary>
        /// IDMMEJ.
        /// </summary>
        public const string IDMMEJ = "IDMMEJ";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDTDAY.
        /// </summary>
        public const string IDTDAY = "IDTDAY";

        /// <summary>
        /// IDSVRNAME.
        /// </summary>
        public const string IDSVRNAME = "IDSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F46L11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDLPNU", "IDLPNU", JdeDataType.String, 80, true, true),
        new JdeField("IDITM", "IDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IDLOTN", "IDLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IDMCU", "IDMCU", JdeDataType.String, 24),
        new JdeField("IDLOCN", "IDLOCN", JdeDataType.String, 40),
        new JdeField("IDPQOR", "IDPQOR", JdeDataType.Numeric),
        new JdeField("IDUOM1", "IDUOM1", JdeDataType.String, 4),
        new JdeField("IDDQTY", "IDDQTY", JdeDataType.Numeric),
        new JdeField("IDUOM2", "IDUOM2", JdeDataType.String, 4),
        new JdeField("IDGWEI", "IDGWEI", JdeDataType.Numeric),
        new JdeField("IDGWUM", "IDGWUM", JdeDataType.String, 4),
        new JdeField("IDGCUB", "IDGCUB", JdeDataType.Numeric),
        new JdeField("IDWIUM", "IDWIUM", JdeDataType.String, 4),
        new JdeField("IDLPNDC", "IDLPNDC", JdeDataType.Date),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDPID", "IDPID", JdeDataType.String, 20),
        new JdeField("IDMKEY", "IDMKEY", JdeDataType.String, 30),
        new JdeField("IDURCD", "IDURCD", JdeDataType.String, 4),
        new JdeField("IDURDT", "IDURDT", JdeDataType.Numeric),
        new JdeField("IDURAB", "IDURAB", JdeDataType.Numeric),
        new JdeField("IDURRF", "IDURRF", JdeDataType.String, 30),
        new JdeField("IDRCDJ", "IDRCDJ", JdeDataType.Numeric),
        new JdeField("IDMMEJ", "IDMMEJ", JdeDataType.Numeric),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDTDAY", "IDTDAY", JdeDataType.Numeric),
        new JdeField("IDSVRNAME", "IDSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L11_0", "Primary Key on IDLPNU, IDITM, IDLOTN", new[] { "IDLPNU", "IDITM", "IDLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L11_2", "Index on IDLPNU", new[] { "IDLPNU" }),
        new JdeIndex("F46L11_3", "Index on IDMCU, IDITM, IDLOCN, IDLOTN", new[] { "IDMCU", "IDITM", "IDLOCN", "IDLOTN" }),
        new JdeIndex("F46L11_4", "Index on IDLPNU, IDMCU, IDLOCN, IDITM", new[] { "IDLPNU", "IDMCU", "IDLOCN", "IDITM" })
    };
}
