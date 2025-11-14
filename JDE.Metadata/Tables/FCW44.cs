using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW44 - .
/// </summary>
public class FCW44 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPC9CMRL.
        /// </summary>
        public const string FPC9CMRL = "FPC9CMRL";

        /// <summary>
        /// FPKCOO.
        /// </summary>
        public const string FPKCOO = "FPKCOO";

        /// <summary>
        /// FPDOCO.
        /// </summary>
        public const string FPDOCO = "FPDOCO";

        /// <summary>
        /// FPDCTO.
        /// </summary>
        public const string FPDCTO = "FPDCTO";

        /// <summary>
        /// FPAN8.
        /// </summary>
        public const string FPAN8 = "FPAN8";

        /// <summary>
        /// FPMCU.
        /// </summary>
        public const string FPMCU = "FPMCU";

        /// <summary>
        /// FPTRDJ.
        /// </summary>
        public const string FPTRDJ = "FPTRDJ";

        /// <summary>
        /// FPDRQJ.
        /// </summary>
        public const string FPDRQJ = "FPDRQJ";

        /// <summary>
        /// FPUORG.
        /// </summary>
        public const string FPUORG = "FPUORG";

        /// <summary>
        /// FPC9QTYRAL.
        /// </summary>
        public const string FPC9QTYRAL = "FPC9QTYRAL";

        /// <summary>
        /// FPC9QTYRALO.
        /// </summary>
        public const string FPC9QTYRALO = "FPC9QTYRALO";

        /// <summary>
        /// FPC9QTYAFF.
        /// </summary>
        public const string FPC9QTYAFF = "FPC9QTYAFF";

        /// <summary>
        /// FPC9LINE.
        /// </summary>
        public const string FPC9LINE = "FPC9LINE";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPUPMJ.
        /// </summary>
        public const string FPUPMJ = "FPUPMJ";

        /// <summary>
        /// FPJOBN.
        /// </summary>
        public const string FPJOBN = "FPJOBN";

        /// <summary>
        /// FPUPMT.
        /// </summary>
        public const string FPUPMT = "FPUPMT";

        /// <summary>
        /// FPAN81.
        /// </summary>
        public const string FPAN81 = "FPAN81";
    }

    /// <inheritdoc />
    public override string TableName => "FCW44";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPC9CMRL", "FPC9CMRL", JdeDataType.String, 20, true, true),
        new JdeField("FPKCOO", "FPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("FPDOCO", "FPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("FPDCTO", "FPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("FPAN8", "FPAN8", JdeDataType.Numeric),
        new JdeField("FPMCU", "FPMCU", JdeDataType.String, 24),
        new JdeField("FPTRDJ", "FPTRDJ", JdeDataType.Numeric),
        new JdeField("FPDRQJ", "FPDRQJ", JdeDataType.Numeric),
        new JdeField("FPUORG", "FPUORG", JdeDataType.Numeric),
        new JdeField("FPC9QTYRAL", "FPC9QTYRAL", JdeDataType.Numeric),
        new JdeField("FPC9QTYRALO", "FPC9QTYRALO", JdeDataType.Numeric),
        new JdeField("FPC9QTYAFF", "FPC9QTYAFF", JdeDataType.Numeric),
        new JdeField("FPC9LINE", "FPC9LINE", JdeDataType.Numeric),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPUPMJ", "FPUPMJ", JdeDataType.Numeric),
        new JdeField("FPJOBN", "FPJOBN", JdeDataType.String, 20),
        new JdeField("FPUPMT", "FPUPMT", JdeDataType.Numeric),
        new JdeField("FPAN81", "FPAN81", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW44_0", "Primary Key on FPC9CMRL, FPKCOO, FPDOCO, FPDCTO", new[] { "FPC9CMRL", "FPKCOO", "FPDOCO", "FPDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
