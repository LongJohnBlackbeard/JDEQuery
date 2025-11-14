using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U207A - .
/// </summary>
public class F74U207A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P9DOCO.
        /// </summary>
        public const string P9DOCO = "P9DOCO";

        /// <summary>
        /// P9LNID.
        /// </summary>
        public const string P9LNID = "P9LNID";

        /// <summary>
        /// P974UGENT.
        /// </summary>
        public const string P974UGENT = "P974UGENT";

        /// <summary>
        /// P974UGLC.
        /// </summary>
        public const string P974UGLC = "P974UGLC";

        /// <summary>
        /// P974UPPLN.
        /// </summary>
        public const string P974UPPLN = "P974UPPLN";

        /// <summary>
        /// P974USTA.
        /// </summary>
        public const string P974USTA = "P974USTA";

        /// <summary>
        /// P974UEFTB.
        /// </summary>
        public const string P974UEFTB = "P974UEFTB";

        /// <summary>
        /// P974UBTE.
        /// </summary>
        public const string P974UBTE = "P974UBTE";

        /// <summary>
        /// P974UEFTE.
        /// </summary>
        public const string P974UEFTE = "P974UEFTE";

        /// <summary>
        /// P974UETE.
        /// </summary>
        public const string P974UETE = "P974UETE";

        /// <summary>
        /// P974UOPID.
        /// </summary>
        public const string P974UOPID = "P974UOPID";

        /// <summary>
        /// P9REM1.
        /// </summary>
        public const string P9REM1 = "P9REM1";

        /// <summary>
        /// P9URCD.
        /// </summary>
        public const string P9URCD = "P9URCD";

        /// <summary>
        /// P9URDT.
        /// </summary>
        public const string P9URDT = "P9URDT";

        /// <summary>
        /// P9URAT.
        /// </summary>
        public const string P9URAT = "P9URAT";

        /// <summary>
        /// P9URAB.
        /// </summary>
        public const string P9URAB = "P9URAB";

        /// <summary>
        /// P9URRF.
        /// </summary>
        public const string P9URRF = "P9URRF";

        /// <summary>
        /// P9USER.
        /// </summary>
        public const string P9USER = "P9USER";

        /// <summary>
        /// P9PID.
        /// </summary>
        public const string P9PID = "P9PID";

        /// <summary>
        /// P9UPMJ.
        /// </summary>
        public const string P9UPMJ = "P9UPMJ";

        /// <summary>
        /// P9UPMT.
        /// </summary>
        public const string P9UPMT = "P9UPMT";

        /// <summary>
        /// P9JOBN.
        /// </summary>
        public const string P9JOBN = "P9JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U207A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P9DOCO", "P9DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("P9LNID", "P9LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("P974UGENT", "P974UGENT", JdeDataType.String, 2),
        new JdeField("P974UGLC", "P974UGLC", JdeDataType.String, 8),
        new JdeField("P974UPPLN", "P974UPPLN", JdeDataType.Numeric, null, true, true),
        new JdeField("P974USTA", "P974USTA", JdeDataType.String, 2),
        new JdeField("P974UEFTB", "P974UEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("P974UBTE", "P974UBTE", JdeDataType.Numeric, null, true, true),
        new JdeField("P974UEFTE", "P974UEFTE", JdeDataType.Numeric),
        new JdeField("P974UETE", "P974UETE", JdeDataType.Numeric),
        new JdeField("P974UOPID", "P974UOPID", JdeDataType.String, 20),
        new JdeField("P9REM1", "P9REM1", JdeDataType.String, 80),
        new JdeField("P9URCD", "P9URCD", JdeDataType.String, 4),
        new JdeField("P9URDT", "P9URDT", JdeDataType.Numeric),
        new JdeField("P9URAT", "P9URAT", JdeDataType.Numeric),
        new JdeField("P9URAB", "P9URAB", JdeDataType.Numeric),
        new JdeField("P9URRF", "P9URRF", JdeDataType.String, 30),
        new JdeField("P9USER", "P9USER", JdeDataType.String, 20),
        new JdeField("P9PID", "P9PID", JdeDataType.String, 20),
        new JdeField("P9UPMJ", "P9UPMJ", JdeDataType.Numeric),
        new JdeField("P9UPMT", "P9UPMT", JdeDataType.Numeric),
        new JdeField("P9JOBN", "P9JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U207A_0", "Primary Key on P9DOCO, P9LNID, P974UPPLN, P974UBTE, P974UEFTB", new[] { "P9DOCO", "P9LNID", "P974UPPLN", "P974UBTE", "P974UEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
