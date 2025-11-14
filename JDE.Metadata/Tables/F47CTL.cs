using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47CTL - .
/// </summary>
public class F47CTL : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z5EDTY.
        /// </summary>
        public const string Z5EDTY = "Z5EDTY";

        /// <summary>
        /// Z5EDSQ.
        /// </summary>
        public const string Z5EDSQ = "Z5EDSQ";

        /// <summary>
        /// Z5EKCO.
        /// </summary>
        public const string Z5EKCO = "Z5EKCO";

        /// <summary>
        /// Z5EDOC.
        /// </summary>
        public const string Z5EDOC = "Z5EDOC";

        /// <summary>
        /// Z5EDCT.
        /// </summary>
        public const string Z5EDCT = "Z5EDCT";

        /// <summary>
        /// Z5EDLN.
        /// </summary>
        public const string Z5EDLN = "Z5EDLN";

        /// <summary>
        /// Z5DEPN.
        /// </summary>
        public const string Z5DEPN = "Z5DEPN";

        /// <summary>
        /// Z5LNID.
        /// </summary>
        public const string Z5LNID = "Z5LNID";

        /// <summary>
        /// Z5SEQN.
        /// </summary>
        public const string Z5SEQN = "Z5SEQN";

        /// <summary>
        /// Z5EV01.
        /// </summary>
        public const string Z5EV01 = "Z5EV01";

        /// <summary>
        /// Z5EDST.
        /// </summary>
        public const string Z5EDST = "Z5EDST";

        /// <summary>
        /// Z5EDFT.
        /// </summary>
        public const string Z5EDFT = "Z5EDFT";

        /// <summary>
        /// Z5EDDT.
        /// </summary>
        public const string Z5EDDT = "Z5EDDT";

        /// <summary>
        /// Z5EDER.
        /// </summary>
        public const string Z5EDER = "Z5EDER";

        /// <summary>
        /// Z5EDDL.
        /// </summary>
        public const string Z5EDDL = "Z5EDDL";

        /// <summary>
        /// Z5EDSP.
        /// </summary>
        public const string Z5EDSP = "Z5EDSP";

        /// <summary>
        /// Z5EDBT.
        /// </summary>
        public const string Z5EDBT = "Z5EDBT";

        /// <summary>
        /// Z5PNID.
        /// </summary>
        public const string Z5PNID = "Z5PNID";

        /// <summary>
        /// Z5URCD.
        /// </summary>
        public const string Z5URCD = "Z5URCD";

        /// <summary>
        /// Z5URDT.
        /// </summary>
        public const string Z5URDT = "Z5URDT";

        /// <summary>
        /// Z5URAT.
        /// </summary>
        public const string Z5URAT = "Z5URAT";

        /// <summary>
        /// Z5URAB.
        /// </summary>
        public const string Z5URAB = "Z5URAB";

        /// <summary>
        /// Z5URRF.
        /// </summary>
        public const string Z5URRF = "Z5URRF";

        /// <summary>
        /// Z5TORG.
        /// </summary>
        public const string Z5TORG = "Z5TORG";

        /// <summary>
        /// Z5USER.
        /// </summary>
        public const string Z5USER = "Z5USER";

        /// <summary>
        /// Z5PID.
        /// </summary>
        public const string Z5PID = "Z5PID";

        /// <summary>
        /// Z5UPMJ.
        /// </summary>
        public const string Z5UPMJ = "Z5UPMJ";

        /// <summary>
        /// Z5UPMT.
        /// </summary>
        public const string Z5UPMT = "Z5UPMT";

        /// <summary>
        /// Z5JOBN.
        /// </summary>
        public const string Z5JOBN = "Z5JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F47CTL";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z5EDTY", "Z5EDTY", JdeDataType.String, 2),
        new JdeField("Z5EDSQ", "Z5EDSQ", JdeDataType.Numeric),
        new JdeField("Z5EKCO", "Z5EKCO", JdeDataType.String, 10, true, true),
        new JdeField("Z5EDOC", "Z5EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Z5EDCT", "Z5EDCT", JdeDataType.String, 4, true, true),
        new JdeField("Z5EDLN", "Z5EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z5DEPN", "Z5DEPN", JdeDataType.String, 60, true, true),
        new JdeField("Z5LNID", "Z5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Z5SEQN", "Z5SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z5EV01", "Z5EV01", JdeDataType.String, 2, true, true),
        new JdeField("Z5EDST", "Z5EDST", JdeDataType.String, 12),
        new JdeField("Z5EDFT", "Z5EDFT", JdeDataType.String, 20),
        new JdeField("Z5EDDT", "Z5EDDT", JdeDataType.Numeric),
        new JdeField("Z5EDER", "Z5EDER", JdeDataType.String, 2),
        new JdeField("Z5EDDL", "Z5EDDL", JdeDataType.Numeric),
        new JdeField("Z5EDSP", "Z5EDSP", JdeDataType.String, 2),
        new JdeField("Z5EDBT", "Z5EDBT", JdeDataType.String, 30),
        new JdeField("Z5PNID", "Z5PNID", JdeDataType.String, 30),
        new JdeField("Z5URCD", "Z5URCD", JdeDataType.String, 4),
        new JdeField("Z5URDT", "Z5URDT", JdeDataType.Numeric),
        new JdeField("Z5URAT", "Z5URAT", JdeDataType.Numeric),
        new JdeField("Z5URAB", "Z5URAB", JdeDataType.Numeric),
        new JdeField("Z5URRF", "Z5URRF", JdeDataType.String, 30),
        new JdeField("Z5TORG", "Z5TORG", JdeDataType.String, 20),
        new JdeField("Z5USER", "Z5USER", JdeDataType.String, 20),
        new JdeField("Z5PID", "Z5PID", JdeDataType.String, 20),
        new JdeField("Z5UPMJ", "Z5UPMJ", JdeDataType.Numeric),
        new JdeField("Z5UPMT", "Z5UPMT", JdeDataType.Numeric),
        new JdeField("Z5JOBN", "Z5JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47CTL_0", "Primary Key on Z5EDOC, Z5EDCT, Z5EKCO, Z5EDLN, Z5EV01, Z5DEPN, Z5LNID, Z5SEQN", new[] { "Z5EDOC", "Z5EDCT", "Z5EKCO", "Z5EDLN", "Z5EV01", "Z5DEPN", "Z5LNID", "Z5SEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
