using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B060 - .
/// </summary>
public class F76B060 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWJOBS.
        /// </summary>
        public const string NWJOBS = "NWJOBS";

        /// <summary>
        /// NWBNNF.
        /// </summary>
        public const string NWBNNF = "NWBNNF";

        /// <summary>
        /// NWBSER.
        /// </summary>
        public const string NWBSER = "NWBSER";

        /// <summary>
        /// NWN001.
        /// </summary>
        public const string NWN001 = "NWN001";

        /// <summary>
        /// NWDCT.
        /// </summary>
        public const string NWDCT = "NWDCT";

        /// <summary>
        /// NWUKID.
        /// </summary>
        public const string NWUKID = "NWUKID";

        /// <summary>
        /// NWTAX.
        /// </summary>
        public const string NWTAX = "NWTAX";

        /// <summary>
        /// NWFCO.
        /// </summary>
        public const string NWFCO = "NWFCO";

        /// <summary>
        /// NWB76MOTY.
        /// </summary>
        public const string NWB76MOTY = "NWB76MOTY";

        /// <summary>
        /// NWB76ELN.
        /// </summary>
        public const string NWB76ELN = "NWB76ELN";

        /// <summary>
        /// NWB76SNF.
        /// </summary>
        public const string NWB76SNF = "NWB76SNF";

        /// <summary>
        /// NWB76EFL.
        /// </summary>
        public const string NWB76EFL = "NWB76EFL";

        /// <summary>
        /// NWB76ISSF.
        /// </summary>
        public const string NWB76ISSF = "NWB76ISSF";

        /// <summary>
        /// NWB76PISF.
        /// </summary>
        public const string NWB76PISF = "NWB76PISF";

        /// <summary>
        /// NWB76COFF.
        /// </summary>
        public const string NWB76COFF = "NWB76COFF";

        /// <summary>
        /// NWB76SERF.
        /// </summary>
        public const string NWB76SERF = "NWB76SERF";

        /// <summary>
        /// NWB76FAF.
        /// </summary>
        public const string NWB76FAF = "NWB76FAF";

        /// <summary>
        /// NWB76INPF.
        /// </summary>
        public const string NWB76INPF = "NWB76INPF";

        /// <summary>
        /// NWB76IMPF.
        /// </summary>
        public const string NWB76IMPF = "NWB76IMPF";

        /// <summary>
        /// NWB76PRF.
        /// </summary>
        public const string NWB76PRF = "NWB76PRF";

        /// <summary>
        /// NWB76LNPF.
        /// </summary>
        public const string NWB76LNPF = "NWB76LNPF";

        /// <summary>
        /// NWB76URAB.
        /// </summary>
        public const string NWB76URAB = "NWB76URAB";

        /// <summary>
        /// NWB76URAT.
        /// </summary>
        public const string NWB76URAT = "NWB76URAT";

        /// <summary>
        /// NWB76URRF.
        /// </summary>
        public const string NWB76URRF = "NWB76URRF";

        /// <summary>
        /// NWB76URDT.
        /// </summary>
        public const string NWB76URDT = "NWB76URDT";

        /// <summary>
        /// NWB76URCD.
        /// </summary>
        public const string NWB76URCD = "NWB76URCD";

        /// <summary>
        /// NWUSER.
        /// </summary>
        public const string NWUSER = "NWUSER";

        /// <summary>
        /// NWPID.
        /// </summary>
        public const string NWPID = "NWPID";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";

        /// <summary>
        /// NWUPMJ.
        /// </summary>
        public const string NWUPMJ = "NWUPMJ";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B060";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWJOBS", "NWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("NWBNNF", "NWBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("NWBSER", "NWBSER", JdeDataType.String, 4, true, true),
        new JdeField("NWN001", "NWN001", JdeDataType.Numeric, null, true, true),
        new JdeField("NWDCT", "NWDCT", JdeDataType.String, 4, true, true),
        new JdeField("NWUKID", "NWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("NWTAX", "NWTAX", JdeDataType.String, 40),
        new JdeField("NWFCO", "NWFCO", JdeDataType.String, 10),
        new JdeField("NWB76MOTY", "NWB76MOTY", JdeDataType.String, 4),
        new JdeField("NWB76ELN", "NWB76ELN", JdeDataType.String, 60),
        new JdeField("NWB76SNF", "NWB76SNF", JdeDataType.String, 6),
        new JdeField("NWB76EFL", "NWB76EFL", JdeDataType.String, 2),
        new JdeField("NWB76ISSF", "NWB76ISSF", JdeDataType.String, 2),
        new JdeField("NWB76PISF", "NWB76PISF", JdeDataType.String, 2),
        new JdeField("NWB76COFF", "NWB76COFF", JdeDataType.String, 2),
        new JdeField("NWB76SERF", "NWB76SERF", JdeDataType.String, 2),
        new JdeField("NWB76FAF", "NWB76FAF", JdeDataType.String, 2),
        new JdeField("NWB76INPF", "NWB76INPF", JdeDataType.String, 2),
        new JdeField("NWB76IMPF", "NWB76IMPF", JdeDataType.String, 2),
        new JdeField("NWB76PRF", "NWB76PRF", JdeDataType.String, 2),
        new JdeField("NWB76LNPF", "NWB76LNPF", JdeDataType.String, 2),
        new JdeField("NWB76URAB", "NWB76URAB", JdeDataType.Numeric),
        new JdeField("NWB76URAT", "NWB76URAT", JdeDataType.Numeric),
        new JdeField("NWB76URRF", "NWB76URRF", JdeDataType.String, 30),
        new JdeField("NWB76URDT", "NWB76URDT", JdeDataType.Numeric),
        new JdeField("NWB76URCD", "NWB76URCD", JdeDataType.String, 4),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B060_0", "Primary Key on NWJOBS, NWBNNF, NWBSER, NWN001, NWDCT, NWUKID", new[] { "NWJOBS", "NWBNNF", "NWBSER", "NWN001", "NWDCT", "NWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B060_2", "Index on NWJOBS, NWTAX, NWFCO, NWBNNF, NWBSER, NWDCT", new[] { "NWJOBS", "NWTAX", "NWFCO", "NWBNNF", "NWBSER", "NWDCT" })
    };
}
