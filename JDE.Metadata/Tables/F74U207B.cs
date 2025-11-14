using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U207B - .
/// </summary>
public class F74U207B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PADOCO.
        /// </summary>
        public const string PADOCO = "PADOCO";

        /// <summary>
        /// PALNID.
        /// </summary>
        public const string PALNID = "PALNID";

        /// <summary>
        /// PA74UGENT.
        /// </summary>
        public const string PA74UGENT = "PA74UGENT";

        /// <summary>
        /// PA74UGLC.
        /// </summary>
        public const string PA74UGLC = "PA74UGLC";

        /// <summary>
        /// PA74UACPL.
        /// </summary>
        public const string PA74UACPL = "PA74UACPL";

        /// <summary>
        /// PACTRY.
        /// </summary>
        public const string PACTRY = "PACTRY";

        /// <summary>
        /// PAFY.
        /// </summary>
        public const string PAFY = "PAFY";

        /// <summary>
        /// PA74USTA.
        /// </summary>
        public const string PA74USTA = "PA74USTA";

        /// <summary>
        /// PA74UEFTB.
        /// </summary>
        public const string PA74UEFTB = "PA74UEFTB";

        /// <summary>
        /// PA74UBTE.
        /// </summary>
        public const string PA74UBTE = "PA74UBTE";

        /// <summary>
        /// PA74UEFTE.
        /// </summary>
        public const string PA74UEFTE = "PA74UEFTE";

        /// <summary>
        /// PA74UETE.
        /// </summary>
        public const string PA74UETE = "PA74UETE";

        /// <summary>
        /// PA74UOPID.
        /// </summary>
        public const string PA74UOPID = "PA74UOPID";

        /// <summary>
        /// PAREM1.
        /// </summary>
        public const string PAREM1 = "PAREM1";

        /// <summary>
        /// PAURCD.
        /// </summary>
        public const string PAURCD = "PAURCD";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U207B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PADOCO", "PADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PALNID", "PALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PA74UGENT", "PA74UGENT", JdeDataType.String, 2),
        new JdeField("PA74UGLC", "PA74UGLC", JdeDataType.String, 8),
        new JdeField("PA74UACPL", "PA74UACPL", JdeDataType.Numeric, null, true, true),
        new JdeField("PACTRY", "PACTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("PAFY", "PAFY", JdeDataType.Numeric, null, true, true),
        new JdeField("PA74USTA", "PA74USTA", JdeDataType.String, 2),
        new JdeField("PA74UEFTB", "PA74UEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PA74UBTE", "PA74UBTE", JdeDataType.Numeric, null, true, true),
        new JdeField("PA74UEFTE", "PA74UEFTE", JdeDataType.Numeric),
        new JdeField("PA74UETE", "PA74UETE", JdeDataType.Numeric),
        new JdeField("PA74UOPID", "PA74UOPID", JdeDataType.String, 20),
        new JdeField("PAREM1", "PAREM1", JdeDataType.String, 80),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U207B_0", "Primary Key on PADOCO, PALNID, PA74UEFTB, PA74UBTE, PA74UACPL, PACTRY, PAFY", new[] { "PADOCO", "PALNID", "PA74UEFTB", "PA74UBTE", "PA74UACPL", "PACTRY", "PAFY" }, isUnique: true, isPrimaryKey: true)
    };
}
