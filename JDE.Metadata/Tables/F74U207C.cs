using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U207C - .
/// </summary>
public class F74U207C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHLNID.
        /// </summary>
        public const string PHLNID = "PHLNID";

        /// <summary>
        /// PH74UGENT.
        /// </summary>
        public const string PH74UGENT = "PH74UGENT";

        /// <summary>
        /// PH74UGLC.
        /// </summary>
        public const string PH74UGLC = "PH74UGLC";

        /// <summary>
        /// PHCTRY.
        /// </summary>
        public const string PHCTRY = "PHCTRY";

        /// <summary>
        /// PHFY.
        /// </summary>
        public const string PHFY = "PHFY";

        /// <summary>
        /// PH74UACPL.
        /// </summary>
        public const string PH74UACPL = "PH74UACPL";

        /// <summary>
        /// PH74UWAPL.
        /// </summary>
        public const string PH74UWAPL = "PH74UWAPL";

        /// <summary>
        /// PH74USTA.
        /// </summary>
        public const string PH74USTA = "PH74USTA";

        /// <summary>
        /// PH74UEFTB.
        /// </summary>
        public const string PH74UEFTB = "PH74UEFTB";

        /// <summary>
        /// PH74UBTE.
        /// </summary>
        public const string PH74UBTE = "PH74UBTE";

        /// <summary>
        /// PH74UEFTE.
        /// </summary>
        public const string PH74UEFTE = "PH74UEFTE";

        /// <summary>
        /// PH74UETE.
        /// </summary>
        public const string PH74UETE = "PH74UETE";

        /// <summary>
        /// PH74UOPID.
        /// </summary>
        public const string PH74UOPID = "PH74UOPID";

        /// <summary>
        /// PHREM1.
        /// </summary>
        public const string PHREM1 = "PHREM1";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U207C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHLNID", "PHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PH74UGENT", "PH74UGENT", JdeDataType.String, 2),
        new JdeField("PH74UGLC", "PH74UGLC", JdeDataType.String, 8),
        new JdeField("PHCTRY", "PHCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("PHFY", "PHFY", JdeDataType.Numeric, null, true, true),
        new JdeField("PH74UACPL", "PH74UACPL", JdeDataType.Numeric, null, true, true),
        new JdeField("PH74UWAPL", "PH74UWAPL", JdeDataType.Numeric, null, true, true),
        new JdeField("PH74USTA", "PH74USTA", JdeDataType.String, 2),
        new JdeField("PH74UEFTB", "PH74UEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PH74UBTE", "PH74UBTE", JdeDataType.Numeric, null, true, true),
        new JdeField("PH74UEFTE", "PH74UEFTE", JdeDataType.Numeric),
        new JdeField("PH74UETE", "PH74UETE", JdeDataType.Numeric),
        new JdeField("PH74UOPID", "PH74UOPID", JdeDataType.String, 20),
        new JdeField("PHREM1", "PHREM1", JdeDataType.String, 80),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U207C_0", "Primary Key on PHDOCO, PHLNID, PH74UEFTB, PH74UBTE, PH74UWAPL, PH74UACPL, PHCTRY, PHFY", new[] { "PHDOCO", "PHLNID", "PH74UEFTB", "PH74UBTE", "PH74UWAPL", "PH74UACPL", "PHCTRY", "PHFY" }, isUnique: true, isPrimaryKey: true)
    };
}
