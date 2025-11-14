using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47111 - .
/// </summary>
public class F47111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z1EDTY.
        /// </summary>
        public const string Z1EDTY = "Z1EDTY";

        /// <summary>
        /// Z1EDSQ.
        /// </summary>
        public const string Z1EDSQ = "Z1EDSQ";

        /// <summary>
        /// Z1EKCO.
        /// </summary>
        public const string Z1EKCO = "Z1EKCO";

        /// <summary>
        /// Z1EDOC.
        /// </summary>
        public const string Z1EDOC = "Z1EDOC";

        /// <summary>
        /// Z1EDCT.
        /// </summary>
        public const string Z1EDCT = "Z1EDCT";

        /// <summary>
        /// Z1EDLN.
        /// </summary>
        public const string Z1EDLN = "Z1EDLN";

        /// <summary>
        /// Z1EDST.
        /// </summary>
        public const string Z1EDST = "Z1EDST";

        /// <summary>
        /// Z1EDFT.
        /// </summary>
        public const string Z1EDFT = "Z1EDFT";

        /// <summary>
        /// Z1EDDT.
        /// </summary>
        public const string Z1EDDT = "Z1EDDT";

        /// <summary>
        /// Z1EDER.
        /// </summary>
        public const string Z1EDER = "Z1EDER";

        /// <summary>
        /// Z1EDDL.
        /// </summary>
        public const string Z1EDDL = "Z1EDDL";

        /// <summary>
        /// Z1EDSP.
        /// </summary>
        public const string Z1EDSP = "Z1EDSP";

        /// <summary>
        /// Z1EDBT.
        /// </summary>
        public const string Z1EDBT = "Z1EDBT";

        /// <summary>
        /// Z1PNID.
        /// </summary>
        public const string Z1PNID = "Z1PNID";

        /// <summary>
        /// Z1ALPH.
        /// </summary>
        public const string Z1ALPH = "Z1ALPH";

        /// <summary>
        /// Z1URCD.
        /// </summary>
        public const string Z1URCD = "Z1URCD";

        /// <summary>
        /// Z1URDT.
        /// </summary>
        public const string Z1URDT = "Z1URDT";

        /// <summary>
        /// Z1URAT.
        /// </summary>
        public const string Z1URAT = "Z1URAT";

        /// <summary>
        /// Z1URAB.
        /// </summary>
        public const string Z1URAB = "Z1URAB";

        /// <summary>
        /// Z1URRF.
        /// </summary>
        public const string Z1URRF = "Z1URRF";

        /// <summary>
        /// Z1TORG.
        /// </summary>
        public const string Z1TORG = "Z1TORG";

        /// <summary>
        /// Z1USER.
        /// </summary>
        public const string Z1USER = "Z1USER";

        /// <summary>
        /// Z1PID.
        /// </summary>
        public const string Z1PID = "Z1PID";

        /// <summary>
        /// Z1JOBN.
        /// </summary>
        public const string Z1JOBN = "Z1JOBN";

        /// <summary>
        /// Z1UPMJ.
        /// </summary>
        public const string Z1UPMJ = "Z1UPMJ";

        /// <summary>
        /// Z1TDAY.
        /// </summary>
        public const string Z1TDAY = "Z1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z1EDTY", "Z1EDTY", JdeDataType.String, 2),
        new JdeField("Z1EDSQ", "Z1EDSQ", JdeDataType.Numeric),
        new JdeField("Z1EKCO", "Z1EKCO", JdeDataType.String, 10, true, true),
        new JdeField("Z1EDOC", "Z1EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Z1EDCT", "Z1EDCT", JdeDataType.String, 4, true, true),
        new JdeField("Z1EDLN", "Z1EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z1EDST", "Z1EDST", JdeDataType.String, 12),
        new JdeField("Z1EDFT", "Z1EDFT", JdeDataType.String, 20),
        new JdeField("Z1EDDT", "Z1EDDT", JdeDataType.Numeric),
        new JdeField("Z1EDER", "Z1EDER", JdeDataType.String, 2),
        new JdeField("Z1EDDL", "Z1EDDL", JdeDataType.Numeric),
        new JdeField("Z1EDSP", "Z1EDSP", JdeDataType.String, 2),
        new JdeField("Z1EDBT", "Z1EDBT", JdeDataType.String, 30),
        new JdeField("Z1PNID", "Z1PNID", JdeDataType.String, 30),
        new JdeField("Z1ALPH", "Z1ALPH", JdeDataType.String, 80),
        new JdeField("Z1URCD", "Z1URCD", JdeDataType.String, 4),
        new JdeField("Z1URDT", "Z1URDT", JdeDataType.Numeric),
        new JdeField("Z1URAT", "Z1URAT", JdeDataType.Numeric),
        new JdeField("Z1URAB", "Z1URAB", JdeDataType.Numeric),
        new JdeField("Z1URRF", "Z1URRF", JdeDataType.String, 30),
        new JdeField("Z1TORG", "Z1TORG", JdeDataType.String, 20),
        new JdeField("Z1USER", "Z1USER", JdeDataType.String, 20),
        new JdeField("Z1PID", "Z1PID", JdeDataType.String, 20),
        new JdeField("Z1JOBN", "Z1JOBN", JdeDataType.String, 20),
        new JdeField("Z1UPMJ", "Z1UPMJ", JdeDataType.Numeric),
        new JdeField("Z1TDAY", "Z1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47111_0", "Primary Key on Z1EDOC, Z1EDCT, Z1EKCO, Z1EDLN", new[] { "Z1EDOC", "Z1EDCT", "Z1EKCO", "Z1EDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F47111_2", "Index on Z1EDST", new[] { "Z1EDST" })
    };
}
