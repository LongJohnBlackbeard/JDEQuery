using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B12TZ - .
/// </summary>
public class F76B12TZ : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZFCO.
        /// </summary>
        public const string SZFCO = "SZFCO";

        /// <summary>
        /// SZB76TNF.
        /// </summary>
        public const string SZB76TNF = "SZB76TNF";

        /// <summary>
        /// SZB76LSER.
        /// </summary>
        public const string SZB76LSER = "SZB76LSER";

        /// <summary>
        /// SZB76LNUM.
        /// </summary>
        public const string SZB76LNUM = "SZB76LNUM";

        /// <summary>
        /// SZB76PRON.
        /// </summary>
        public const string SZB76PRON = "SZB76PRON";

        /// <summary>
        /// SZB76RSPC.
        /// </summary>
        public const string SZB76RSPC = "SZB76RSPC";

        /// <summary>
        /// SZB76EPRD.
        /// </summary>
        public const string SZB76EPRD = "SZB76EPRD";

        /// <summary>
        /// SZB76EPRT.
        /// </summary>
        public const string SZB76EPRT = "SZB76EPRT";

        /// <summary>
        /// SZB76ERN.
        /// </summary>
        public const string SZB76ERN = "SZB76ERN";

        /// <summary>
        /// SZB76DPEN.
        /// </summary>
        public const string SZB76DPEN = "SZB76DPEN";

        /// <summary>
        /// SZB76DPED.
        /// </summary>
        public const string SZB76DPED = "SZB76DPED";

        /// <summary>
        /// SZB76DPET.
        /// </summary>
        public const string SZB76DPET = "SZB76DPET";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B12TZ";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZFCO", "SZFCO", JdeDataType.String, 10),
        new JdeField("SZB76TNF", "SZB76TNF", JdeDataType.String, 20),
        new JdeField("SZB76LSER", "SZB76LSER", JdeDataType.String, 20),
        new JdeField("SZB76LNUM", "SZB76LNUM", JdeDataType.Numeric),
        new JdeField("SZB76PRON", "SZB76PRON", JdeDataType.Numeric),
        new JdeField("SZB76RSPC", "SZB76RSPC", JdeDataType.Numeric),
        new JdeField("SZB76EPRD", "SZB76EPRD", JdeDataType.Numeric),
        new JdeField("SZB76EPRT", "SZB76EPRT", JdeDataType.Numeric),
        new JdeField("SZB76ERN", "SZB76ERN", JdeDataType.String, 60),
        new JdeField("SZB76DPEN", "SZB76DPEN", JdeDataType.Numeric),
        new JdeField("SZB76DPED", "SZB76DPED", JdeDataType.Numeric),
        new JdeField("SZB76DPET", "SZB76DPET", JdeDataType.Numeric),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B12TZ_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
