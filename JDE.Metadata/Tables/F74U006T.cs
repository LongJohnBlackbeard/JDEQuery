using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U006T - .
/// </summary>
public class F74U006T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PC74UTCB.
        /// </summary>
        public const string PC74UTCB = "PC74UTCB";

        /// <summary>
        /// PC74UPMIX.
        /// </summary>
        public const string PC74UPMIX = "PC74UPMIX";

        /// <summary>
        /// PC74UFXR.
        /// </summary>
        public const string PC74UFXR = "PC74UFXR";

        /// <summary>
        /// PC74UTRE.
        /// </summary>
        public const string PC74UTRE = "PC74UTRE";

        /// <summary>
        /// PC74UTCE.
        /// </summary>
        public const string PC74UTCE = "PC74UTCE";

        /// <summary>
        /// PC74UPC.
        /// </summary>
        public const string PC74UPC = "PC74UPC";

        /// <summary>
        /// PC74UVOO.
        /// </summary>
        public const string PC74UVOO = "PC74UVOO";

        /// <summary>
        /// PC74UEFTB.
        /// </summary>
        public const string PC74UEFTB = "PC74UEFTB";

        /// <summary>
        /// PC74UEFTE.
        /// </summary>
        public const string PC74UEFTE = "PC74UEFTE";

        /// <summary>
        /// PCASII.
        /// </summary>
        public const string PCASII = "PCASII";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

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
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PC74UTXA1.
        /// </summary>
        public const string PC74UTXA1 = "PC74UTXA1";
    }

    /// <inheritdoc />
    public override string TableName => "F74U006T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PC74UTCB", "PC74UTCB", JdeDataType.String, 4),
        new JdeField("PC74UPMIX", "PC74UPMIX", JdeDataType.String, 2),
        new JdeField("PC74UFXR", "PC74UFXR", JdeDataType.String, 20),
        new JdeField("PC74UTRE", "PC74UTRE", JdeDataType.String, 20),
        new JdeField("PC74UTCE", "PC74UTCE", JdeDataType.String, 4),
        new JdeField("PC74UPC", "PC74UPC", JdeDataType.Numeric),
        new JdeField("PC74UVOO", "PC74UVOO", JdeDataType.String, 6),
        new JdeField("PC74UEFTB", "PC74UEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PC74UEFTE", "PC74UEFTE", JdeDataType.Numeric),
        new JdeField("PCASII", "PCASII", JdeDataType.String, 52),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PC74UTXA1", "PC74UTXA1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U006T_0", "Primary Key on PCMCU, PC74UEFTB", new[] { "PCMCU", "PC74UEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
