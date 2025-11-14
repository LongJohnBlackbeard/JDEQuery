using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0202 - .
/// </summary>
public class F74U0202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P274UBKCD.
        /// </summary>
        public const string P274UBKCD = "P274UBKCD";

        /// <summary>
        /// P274UIBNO.
        /// </summary>
        public const string P274UIBNO = "P274UIBNO";

        /// <summary>
        /// P274UINTR.
        /// </summary>
        public const string P274UINTR = "P274UINTR";

        /// <summary>
        /// P274UEFTB.
        /// </summary>
        public const string P274UEFTB = "P274UEFTB";

        /// <summary>
        /// P274UEFTE.
        /// </summary>
        public const string P274UEFTE = "P274UEFTE";

        /// <summary>
        /// P274USEQN.
        /// </summary>
        public const string P274USEQN = "P274USEQN";

        /// <summary>
        /// P274UEUF.
        /// </summary>
        public const string P274UEUF = "P274UEUF";

        /// <summary>
        /// P274UIRF.
        /// </summary>
        public const string P274UIRF = "P274UIRF";

        /// <summary>
        /// P274ULICR.
        /// </summary>
        public const string P274ULICR = "P274ULICR";

        /// <summary>
        /// P274ULIGR.
        /// </summary>
        public const string P274ULIGR = "P274ULIGR";

        /// <summary>
        /// P2URDT.
        /// </summary>
        public const string P2URDT = "P2URDT";

        /// <summary>
        /// P2URAT.
        /// </summary>
        public const string P2URAT = "P2URAT";

        /// <summary>
        /// P2URAB.
        /// </summary>
        public const string P2URAB = "P2URAB";

        /// <summary>
        /// P2URRF.
        /// </summary>
        public const string P2URRF = "P2URRF";

        /// <summary>
        /// P2USER.
        /// </summary>
        public const string P2USER = "P2USER";

        /// <summary>
        /// P2PID.
        /// </summary>
        public const string P2PID = "P2PID";

        /// <summary>
        /// P2UPMJ.
        /// </summary>
        public const string P2UPMJ = "P2UPMJ";

        /// <summary>
        /// P2UPMT.
        /// </summary>
        public const string P2UPMT = "P2UPMT";

        /// <summary>
        /// P2JOBN.
        /// </summary>
        public const string P2JOBN = "P2JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P274UBKCD", "P274UBKCD", JdeDataType.String, 6, true, true),
        new JdeField("P274UIBNO", "P274UIBNO", JdeDataType.String, 160),
        new JdeField("P274UINTR", "P274UINTR", JdeDataType.Numeric),
        new JdeField("P274UEFTB", "P274UEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("P274UEFTE", "P274UEFTE", JdeDataType.Numeric),
        new JdeField("P274USEQN", "P274USEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("P274UEUF", "P274UEUF", JdeDataType.String, 2),
        new JdeField("P274UIRF", "P274UIRF", JdeDataType.String, 2),
        new JdeField("P274ULICR", "P274ULICR", JdeDataType.Numeric),
        new JdeField("P274ULIGR", "P274ULIGR", JdeDataType.Numeric),
        new JdeField("P2URDT", "P2URDT", JdeDataType.Numeric),
        new JdeField("P2URAT", "P2URAT", JdeDataType.Numeric),
        new JdeField("P2URAB", "P2URAB", JdeDataType.Numeric),
        new JdeField("P2URRF", "P2URRF", JdeDataType.String, 30),
        new JdeField("P2USER", "P2USER", JdeDataType.String, 20),
        new JdeField("P2PID", "P2PID", JdeDataType.String, 20),
        new JdeField("P2UPMJ", "P2UPMJ", JdeDataType.Numeric),
        new JdeField("P2UPMT", "P2UPMT", JdeDataType.Numeric),
        new JdeField("P2JOBN", "P2JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0202_0", "Primary Key on P274UBKCD, P274UEFTB, P274USEQN", new[] { "P274UBKCD", "P274UEFTB", "P274USEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0202_2", "Index on P274UBKCD, P274UEFTB", new[] { "P274UBKCD", "P274UEFTB" })
    };
}
