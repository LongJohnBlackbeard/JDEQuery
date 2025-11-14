using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470473 - .
/// </summary>
public class F470473 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S7EDTY.
        /// </summary>
        public const string S7EDTY = "S7EDTY";

        /// <summary>
        /// S7EDSQ.
        /// </summary>
        public const string S7EDSQ = "S7EDSQ";

        /// <summary>
        /// S7EKCO.
        /// </summary>
        public const string S7EKCO = "S7EKCO";

        /// <summary>
        /// S7EDOC.
        /// </summary>
        public const string S7EDOC = "S7EDOC";

        /// <summary>
        /// S7EDCT.
        /// </summary>
        public const string S7EDCT = "S7EDCT";

        /// <summary>
        /// S7EDLN.
        /// </summary>
        public const string S7EDLN = "S7EDLN";

        /// <summary>
        /// S7EDCLN.
        /// </summary>
        public const string S7EDCLN = "S7EDCLN";

        /// <summary>
        /// S7EDSP.
        /// </summary>
        public const string S7EDSP = "S7EDSP";

        /// <summary>
        /// S7EDBT.
        /// </summary>
        public const string S7EDBT = "S7EDBT";

        /// <summary>
        /// S7OSEQ.
        /// </summary>
        public const string S7OSEQ = "S7OSEQ";

        /// <summary>
        /// S7LITM.
        /// </summary>
        public const string S7LITM = "S7LITM";

        /// <summary>
        /// S7ASN.
        /// </summary>
        public const string S7ASN = "S7ASN";

        /// <summary>
        /// S7AST.
        /// </summary>
        public const string S7AST = "S7AST";

        /// <summary>
        /// S7DL01.
        /// </summary>
        public const string S7DL01 = "S7DL01";

        /// <summary>
        /// S7UPRC.
        /// </summary>
        public const string S7UPRC = "S7UPRC";

        /// <summary>
        /// S7CHGREF.
        /// </summary>
        public const string S7CHGREF = "S7CHGREF";

        /// <summary>
        /// S7TXA1.
        /// </summary>
        public const string S7TXA1 = "S7TXA1";

        /// <summary>
        /// S7EXR1.
        /// </summary>
        public const string S7EXR1 = "S7EXR1";

        /// <summary>
        /// S7TA1.
        /// </summary>
        public const string S7TA1 = "S7TA1";

        /// <summary>
        /// S7TA2.
        /// </summary>
        public const string S7TA2 = "S7TA2";

        /// <summary>
        /// S7TA3.
        /// </summary>
        public const string S7TA3 = "S7TA3";

        /// <summary>
        /// S7TA4.
        /// </summary>
        public const string S7TA4 = "S7TA4";

        /// <summary>
        /// S7TA5.
        /// </summary>
        public const string S7TA5 = "S7TA5";

        /// <summary>
        /// S7TXR1.
        /// </summary>
        public const string S7TXR1 = "S7TXR1";

        /// <summary>
        /// S7TXR2.
        /// </summary>
        public const string S7TXR2 = "S7TXR2";

        /// <summary>
        /// S7TXR3.
        /// </summary>
        public const string S7TXR3 = "S7TXR3";

        /// <summary>
        /// S7TXR4.
        /// </summary>
        public const string S7TXR4 = "S7TXR4";

        /// <summary>
        /// S7TXR5.
        /// </summary>
        public const string S7TXR5 = "S7TXR5";

        /// <summary>
        /// S7TAXT.
        /// </summary>
        public const string S7TAXT = "S7TAXT";

        /// <summary>
        /// S7TAX2.
        /// </summary>
        public const string S7TAX2 = "S7TAX2";

        /// <summary>
        /// S7TAX3.
        /// </summary>
        public const string S7TAX3 = "S7TAX3";

        /// <summary>
        /// S7TAX4.
        /// </summary>
        public const string S7TAX4 = "S7TAX4";

        /// <summary>
        /// S7TAX5.
        /// </summary>
        public const string S7TAX5 = "S7TAX5";

        /// <summary>
        /// S7DSCT.
        /// </summary>
        public const string S7DSCT = "S7DSCT";

        /// <summary>
        /// S7DCP.
        /// </summary>
        public const string S7DCP = "S7DCP";

        /// <summary>
        /// S7STAM.
        /// </summary>
        public const string S7STAM = "S7STAM";

        /// <summary>
        /// S7TRAT.
        /// </summary>
        public const string S7TRAT = "S7TRAT";

        /// <summary>
        /// S7FUT1.
        /// </summary>
        public const string S7FUT1 = "S7FUT1";

        /// <summary>
        /// S7FUT2.
        /// </summary>
        public const string S7FUT2 = "S7FUT2";

        /// <summary>
        /// S7FUT4.
        /// </summary>
        public const string S7FUT4 = "S7FUT4";

        /// <summary>
        /// S7FUT5.
        /// </summary>
        public const string S7FUT5 = "S7FUT5";

        /// <summary>
        /// S7X1.
        /// </summary>
        public const string S7X1 = "S7X1";

        /// <summary>
        /// S7X2.
        /// </summary>
        public const string S7X2 = "S7X2";

        /// <summary>
        /// S7D1FU.
        /// </summary>
        public const string S7D1FU = "S7D1FU";

        /// <summary>
        /// S7D2FU.
        /// </summary>
        public const string S7D2FU = "S7D2FU";

        /// <summary>
        /// S7TORG.
        /// </summary>
        public const string S7TORG = "S7TORG";

        /// <summary>
        /// S7USER.
        /// </summary>
        public const string S7USER = "S7USER";

        /// <summary>
        /// S7PID.
        /// </summary>
        public const string S7PID = "S7PID";

        /// <summary>
        /// S7JOBN.
        /// </summary>
        public const string S7JOBN = "S7JOBN";

        /// <summary>
        /// S7UPMJ.
        /// </summary>
        public const string S7UPMJ = "S7UPMJ";

        /// <summary>
        /// S7UPMT.
        /// </summary>
        public const string S7UPMT = "S7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F470473";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S7EDTY", "S7EDTY", JdeDataType.String, 2),
        new JdeField("S7EDSQ", "S7EDSQ", JdeDataType.Numeric),
        new JdeField("S7EKCO", "S7EKCO", JdeDataType.String, 10, true, true),
        new JdeField("S7EDOC", "S7EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("S7EDCT", "S7EDCT", JdeDataType.String, 4, true, true),
        new JdeField("S7EDLN", "S7EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S7EDCLN", "S7EDCLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S7EDSP", "S7EDSP", JdeDataType.String, 2),
        new JdeField("S7EDBT", "S7EDBT", JdeDataType.String, 30),
        new JdeField("S7OSEQ", "S7OSEQ", JdeDataType.Numeric),
        new JdeField("S7LITM", "S7LITM", JdeDataType.String, 50),
        new JdeField("S7ASN", "S7ASN", JdeDataType.String, 16),
        new JdeField("S7AST", "S7AST", JdeDataType.String, 16),
        new JdeField("S7DL01", "S7DL01", JdeDataType.String, 60),
        new JdeField("S7UPRC", "S7UPRC", JdeDataType.Numeric),
        new JdeField("S7CHGREF", "S7CHGREF", JdeDataType.String, 40),
        new JdeField("S7TXA1", "S7TXA1", JdeDataType.String, 20),
        new JdeField("S7EXR1", "S7EXR1", JdeDataType.String, 4),
        new JdeField("S7TA1", "S7TA1", JdeDataType.Numeric),
        new JdeField("S7TA2", "S7TA2", JdeDataType.Numeric),
        new JdeField("S7TA3", "S7TA3", JdeDataType.Numeric),
        new JdeField("S7TA4", "S7TA4", JdeDataType.Numeric),
        new JdeField("S7TA5", "S7TA5", JdeDataType.Numeric),
        new JdeField("S7TXR1", "S7TXR1", JdeDataType.Numeric),
        new JdeField("S7TXR2", "S7TXR2", JdeDataType.Numeric),
        new JdeField("S7TXR3", "S7TXR3", JdeDataType.Numeric),
        new JdeField("S7TXR4", "S7TXR4", JdeDataType.Numeric),
        new JdeField("S7TXR5", "S7TXR5", JdeDataType.Numeric),
        new JdeField("S7TAXT", "S7TAXT", JdeDataType.Numeric),
        new JdeField("S7TAX2", "S7TAX2", JdeDataType.Numeric),
        new JdeField("S7TAX3", "S7TAX3", JdeDataType.Numeric),
        new JdeField("S7TAX4", "S7TAX4", JdeDataType.Numeric),
        new JdeField("S7TAX5", "S7TAX5", JdeDataType.Numeric),
        new JdeField("S7DSCT", "S7DSCT", JdeDataType.Numeric),
        new JdeField("S7DCP", "S7DCP", JdeDataType.Numeric),
        new JdeField("S7STAM", "S7STAM", JdeDataType.Numeric),
        new JdeField("S7TRAT", "S7TRAT", JdeDataType.Numeric),
        new JdeField("S7FUT1", "S7FUT1", JdeDataType.Numeric),
        new JdeField("S7FUT2", "S7FUT2", JdeDataType.Numeric),
        new JdeField("S7FUT4", "S7FUT4", JdeDataType.String, 50),
        new JdeField("S7FUT5", "S7FUT5", JdeDataType.String, 50),
        new JdeField("S7X1", "S7X1", JdeDataType.String, 2),
        new JdeField("S7X2", "S7X2", JdeDataType.String, 2),
        new JdeField("S7D1FU", "S7D1FU", JdeDataType.Numeric),
        new JdeField("S7D2FU", "S7D2FU", JdeDataType.Numeric),
        new JdeField("S7TORG", "S7TORG", JdeDataType.String, 20),
        new JdeField("S7USER", "S7USER", JdeDataType.String, 20),
        new JdeField("S7PID", "S7PID", JdeDataType.String, 20),
        new JdeField("S7JOBN", "S7JOBN", JdeDataType.String, 20),
        new JdeField("S7UPMJ", "S7UPMJ", JdeDataType.Numeric),
        new JdeField("S7UPMT", "S7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470473_0", "Primary Key on S7EKCO, S7EDOC, S7EDCT, S7EDLN, S7EDCLN", new[] { "S7EKCO", "S7EDOC", "S7EDCT", "S7EDLN", "S7EDCLN" }, isUnique: true, isPrimaryKey: true)
    };
}
