using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I385 - .
/// </summary>
public class F75I385 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDKCOO.
        /// </summary>
        public const string EDKCOO = "EDKCOO";

        /// <summary>
        /// EDDOCO.
        /// </summary>
        public const string EDDOCO = "EDDOCO";

        /// <summary>
        /// EDDCTO.
        /// </summary>
        public const string EDDCTO = "EDDCTO";

        /// <summary>
        /// EDDOC.
        /// </summary>
        public const string EDDOC = "EDDOC";

        /// <summary>
        /// EDDCT.
        /// </summary>
        public const string EDDCT = "EDDCT";

        /// <summary>
        /// EDKCO.
        /// </summary>
        public const string EDKCO = "EDKCO";

        /// <summary>
        /// EDMCU.
        /// </summary>
        public const string EDMCU = "EDMCU";

        /// <summary>
        /// EDOSEQ.
        /// </summary>
        public const string EDOSEQ = "EDOSEQ";

        /// <summary>
        /// EDLNID.
        /// </summary>
        public const string EDLNID = "EDLNID";

        /// <summary>
        /// EDLITM.
        /// </summary>
        public const string EDLITM = "EDLITM";

        /// <summary>
        /// EDAITM.
        /// </summary>
        public const string EDAITM = "EDAITM";

        /// <summary>
        /// EDUOM.
        /// </summary>
        public const string EDUOM = "EDUOM";

        /// <summary>
        /// EDQTYS.
        /// </summary>
        public const string EDQTYS = "EDQTYS";

        /// <summary>
        /// EDUORG.
        /// </summary>
        public const string EDUORG = "EDUORG";

        /// <summary>
        /// EDSOQS.
        /// </summary>
        public const string EDSOQS = "EDSOQS";

        /// <summary>
        /// EDUPRC.
        /// </summary>
        public const string EDUPRC = "EDUPRC";

        /// <summary>
        /// EDAEXP.
        /// </summary>
        public const string EDAEXP = "EDAEXP";

        /// <summary>
        /// EDDCPER.
        /// </summary>
        public const string EDDCPER = "EDDCPER";

        /// <summary>
        /// EDYTDU.
        /// </summary>
        public const string EDYTDU = "EDYTDU";

        /// <summary>
        /// EDCRCD.
        /// </summary>
        public const string EDCRCD = "EDCRCD";

        /// <summary>
        /// EDAST.
        /// </summary>
        public const string EDAST = "EDAST";

        /// <summary>
        /// EDI75TXTY.
        /// </summary>
        public const string EDI75TXTY = "EDI75TXTY";

        /// <summary>
        /// EDDSC1.
        /// </summary>
        public const string EDDSC1 = "EDDSC1";

        /// <summary>
        /// EDFVTR.
        /// </summary>
        public const string EDFVTR = "EDFVTR";

        /// <summary>
        /// EDTORG.
        /// </summary>
        public const string EDTORG = "EDTORG";

        /// <summary>
        /// EDDVAN.
        /// </summary>
        public const string EDDVAN = "EDDVAN";

        /// <summary>
        /// EDAN8.
        /// </summary>
        public const string EDAN8 = "EDAN8";

        /// <summary>
        /// EDLOTN.
        /// </summary>
        public const string EDLOTN = "EDLOTN";

        /// <summary>
        /// EDLOCN.
        /// </summary>
        public const string EDLOCN = "EDLOCN";

        /// <summary>
        /// EDPSN.
        /// </summary>
        public const string EDPSN = "EDPSN";

        /// <summary>
        /// EDSHAN.
        /// </summary>
        public const string EDSHAN = "EDSHAN";

        /// <summary>
        /// EDDSC2.
        /// </summary>
        public const string EDDSC2 = "EDDSC2";

        /// <summary>
        /// EDIVD.
        /// </summary>
        public const string EDIVD = "EDIVD";

        /// <summary>
        /// EDDGL.
        /// </summary>
        public const string EDDGL = "EDDGL";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I385";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDKCOO", "EDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EDDOCO", "EDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDCTO", "EDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EDDOC", "EDDOC", JdeDataType.Numeric),
        new JdeField("EDDCT", "EDDCT", JdeDataType.String, 4),
        new JdeField("EDKCO", "EDKCO", JdeDataType.String, 10),
        new JdeField("EDMCU", "EDMCU", JdeDataType.String, 24, true, true),
        new JdeField("EDOSEQ", "EDOSEQ", JdeDataType.Numeric),
        new JdeField("EDLNID", "EDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("EDLITM", "EDLITM", JdeDataType.String, 50, true, true),
        new JdeField("EDAITM", "EDAITM", JdeDataType.String, 50),
        new JdeField("EDUOM", "EDUOM", JdeDataType.String, 4),
        new JdeField("EDQTYS", "EDQTYS", JdeDataType.Numeric),
        new JdeField("EDUORG", "EDUORG", JdeDataType.Numeric),
        new JdeField("EDSOQS", "EDSOQS", JdeDataType.Numeric),
        new JdeField("EDUPRC", "EDUPRC", JdeDataType.Numeric),
        new JdeField("EDAEXP", "EDAEXP", JdeDataType.Numeric),
        new JdeField("EDDCPER", "EDDCPER", JdeDataType.Numeric),
        new JdeField("EDYTDU", "EDYTDU", JdeDataType.Numeric),
        new JdeField("EDCRCD", "EDCRCD", JdeDataType.String, 6),
        new JdeField("EDAST", "EDAST", JdeDataType.String, 16, true, true),
        new JdeField("EDI75TXTY", "EDI75TXTY", JdeDataType.String, 10),
        new JdeField("EDDSC1", "EDDSC1", JdeDataType.String, 60),
        new JdeField("EDFVTR", "EDFVTR", JdeDataType.Numeric),
        new JdeField("EDTORG", "EDTORG", JdeDataType.String, 20),
        new JdeField("EDDVAN", "EDDVAN", JdeDataType.Numeric),
        new JdeField("EDAN8", "EDAN8", JdeDataType.Numeric),
        new JdeField("EDLOTN", "EDLOTN", JdeDataType.String, 60),
        new JdeField("EDLOCN", "EDLOCN", JdeDataType.String, 40),
        new JdeField("EDPSN", "EDPSN", JdeDataType.Numeric),
        new JdeField("EDSHAN", "EDSHAN", JdeDataType.Numeric),
        new JdeField("EDDSC2", "EDDSC2", JdeDataType.String, 60),
        new JdeField("EDIVD", "EDIVD", JdeDataType.Numeric),
        new JdeField("EDDGL", "EDDGL", JdeDataType.Numeric),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I385_0", "Primary Key on EDKCOO, EDDOCO, EDDCTO, EDMCU, EDLITM, EDAST, EDLNID", new[] { "EDKCOO", "EDDOCO", "EDDCTO", "EDMCU", "EDLITM", "EDAST", "EDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
