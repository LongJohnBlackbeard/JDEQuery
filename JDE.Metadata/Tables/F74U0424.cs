using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0424 - .
/// </summary>
public class F74U0424 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLDOCO.
        /// </summary>
        public const string PLDOCO = "PLDOCO";

        /// <summary>
        /// PLDCTO.
        /// </summary>
        public const string PLDCTO = "PLDCTO";

        /// <summary>
        /// PLKCOO.
        /// </summary>
        public const string PLKCOO = "PLKCOO";

        /// <summary>
        /// PLSFXO.
        /// </summary>
        public const string PLSFXO = "PLSFXO";

        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLLNID.
        /// </summary>
        public const string PLLNID = "PLLNID";

        /// <summary>
        /// PL74UPYCD.
        /// </summary>
        public const string PL74UPYCD = "PL74UPYCD";

        /// <summary>
        /// PL74UAMT1.
        /// </summary>
        public const string PL74UAMT1 = "PL74UAMT1";

        /// <summary>
        /// PL74UAMT2.
        /// </summary>
        public const string PL74UAMT2 = "PL74UAMT2";

        /// <summary>
        /// PL74UAMT3.
        /// </summary>
        public const string PL74UAMT3 = "PL74UAMT3";

        /// <summary>
        /// PL74UAMT4.
        /// </summary>
        public const string PL74UAMT4 = "PL74UAMT4";

        /// <summary>
        /// PL74UAMT5.
        /// </summary>
        public const string PL74UAMT5 = "PL74UAMT5";

        /// <summary>
        /// PL74UAMT6.
        /// </summary>
        public const string PL74UAMT6 = "PL74UAMT6";

        /// <summary>
        /// PL74UAMT7.
        /// </summary>
        public const string PL74UAMT7 = "PL74UAMT7";

        /// <summary>
        /// PL74UAMT8.
        /// </summary>
        public const string PL74UAMT8 = "PL74UAMT8";

        /// <summary>
        /// PL74UAMT9.
        /// </summary>
        public const string PL74UAMT9 = "PL74UAMT9";

        /// <summary>
        /// PL74UAMT10.
        /// </summary>
        public const string PL74UAMT10 = "PL74UAMT10";

        /// <summary>
        /// PL74UAMT11.
        /// </summary>
        public const string PL74UAMT11 = "PL74UAMT11";

        /// <summary>
        /// PL74UAMT12.
        /// </summary>
        public const string PL74UAMT12 = "PL74UAMT12";

        /// <summary>
        /// PL74UAMT13.
        /// </summary>
        public const string PL74UAMT13 = "PL74UAMT13";

        /// <summary>
        /// PL74UAMT14.
        /// </summary>
        public const string PL74UAMT14 = "PL74UAMT14";

        /// <summary>
        /// PL74UAMT15.
        /// </summary>
        public const string PL74UAMT15 = "PL74UAMT15";

        /// <summary>
        /// PL74UTAMT.
        /// </summary>
        public const string PL74UTAMT = "PL74UTAMT";

        /// <summary>
        /// PL74ULKDFG.
        /// </summary>
        public const string PL74ULKDFG = "PL74ULKDFG";

        /// <summary>
        /// PLOBJ.
        /// </summary>
        public const string PLOBJ = "PLOBJ";

        /// <summary>
        /// PLSUB.
        /// </summary>
        public const string PLSUB = "PLSUB";

        /// <summary>
        /// PLSBLT.
        /// </summary>
        public const string PLSBLT = "PLSBLT";

        /// <summary>
        /// PL74UDTE1.
        /// </summary>
        public const string PL74UDTE1 = "PL74UDTE1";

        /// <summary>
        /// PL74UDTE2.
        /// </summary>
        public const string PL74UDTE2 = "PL74UDTE2";

        /// <summary>
        /// PLDSC1.
        /// </summary>
        public const string PLDSC1 = "PLDSC1";

        /// <summary>
        /// PLDSC2.
        /// </summary>
        public const string PLDSC2 = "PLDSC2";

        /// <summary>
        /// PL74UNUM1.
        /// </summary>
        public const string PL74UNUM1 = "PL74UNUM1";

        /// <summary>
        /// PL74UNUM2.
        /// </summary>
        public const string PL74UNUM2 = "PL74UNUM2";

        /// <summary>
        /// PL74UNUM3.
        /// </summary>
        public const string PL74UNUM3 = "PL74UNUM3";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";

        /// <summary>
        /// PLMKEY.
        /// </summary>
        public const string PLMKEY = "PLMKEY";

        /// <summary>
        /// PL74UTOTA.
        /// </summary>
        public const string PL74UTOTA = "PL74UTOTA";

        /// <summary>
        /// PL74UTOTB.
        /// </summary>
        public const string PL74UTOTB = "PL74UTOTB";

        /// <summary>
        /// PLSBL.
        /// </summary>
        public const string PLSBL = "PLSBL";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0424";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLDOCO", "PLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PLDCTO", "PLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PLKCOO", "PLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PLSFXO", "PLSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24, true, true),
        new JdeField("PLLNID", "PLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PL74UPYCD", "PL74UPYCD", JdeDataType.Numeric, null, true, true),
        new JdeField("PL74UAMT1", "PL74UAMT1", JdeDataType.Numeric),
        new JdeField("PL74UAMT2", "PL74UAMT2", JdeDataType.Numeric),
        new JdeField("PL74UAMT3", "PL74UAMT3", JdeDataType.Numeric),
        new JdeField("PL74UAMT4", "PL74UAMT4", JdeDataType.Numeric),
        new JdeField("PL74UAMT5", "PL74UAMT5", JdeDataType.Numeric),
        new JdeField("PL74UAMT6", "PL74UAMT6", JdeDataType.Numeric),
        new JdeField("PL74UAMT7", "PL74UAMT7", JdeDataType.Numeric),
        new JdeField("PL74UAMT8", "PL74UAMT8", JdeDataType.Numeric),
        new JdeField("PL74UAMT9", "PL74UAMT9", JdeDataType.Numeric),
        new JdeField("PL74UAMT10", "PL74UAMT10", JdeDataType.Numeric),
        new JdeField("PL74UAMT11", "PL74UAMT11", JdeDataType.Numeric),
        new JdeField("PL74UAMT12", "PL74UAMT12", JdeDataType.Numeric),
        new JdeField("PL74UAMT13", "PL74UAMT13", JdeDataType.Numeric),
        new JdeField("PL74UAMT14", "PL74UAMT14", JdeDataType.Numeric),
        new JdeField("PL74UAMT15", "PL74UAMT15", JdeDataType.Numeric),
        new JdeField("PL74UTAMT", "PL74UTAMT", JdeDataType.Numeric),
        new JdeField("PL74ULKDFG", "PL74ULKDFG", JdeDataType.String, 2),
        new JdeField("PLOBJ", "PLOBJ", JdeDataType.String, 12),
        new JdeField("PLSUB", "PLSUB", JdeDataType.String, 16),
        new JdeField("PLSBLT", "PLSBLT", JdeDataType.String, 2),
        new JdeField("PL74UDTE1", "PL74UDTE1", JdeDataType.Numeric),
        new JdeField("PL74UDTE2", "PL74UDTE2", JdeDataType.Numeric),
        new JdeField("PLDSC1", "PLDSC1", JdeDataType.String, 60),
        new JdeField("PLDSC2", "PLDSC2", JdeDataType.String, 60),
        new JdeField("PL74UNUM1", "PL74UNUM1", JdeDataType.Numeric),
        new JdeField("PL74UNUM2", "PL74UNUM2", JdeDataType.Numeric),
        new JdeField("PL74UNUM3", "PL74UNUM3", JdeDataType.Numeric),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric),
        new JdeField("PLMKEY", "PLMKEY", JdeDataType.String, 30),
        new JdeField("PL74UTOTA", "PL74UTOTA", JdeDataType.Numeric),
        new JdeField("PL74UTOTB", "PL74UTOTB", JdeDataType.Numeric),
        new JdeField("PLSBL", "PLSBL", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0424_0", "Primary Key on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLLNID, PLMCU, PL74UPYCD", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLLNID", "PLMCU", "PL74UPYCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0424_2", "Index on PLKCOO, PLDCTO, PLSFXO", new[] { "PLKCOO", "PLDCTO", "PLSFXO" }),
        new JdeIndex("F74U0424_3", "Index on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLMCU, PL74UPYCD", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLMCU", "PL74UPYCD" }),
        new JdeIndex("F74U0424_4", "Index on PLDOCO, PLDCTO, PLKCOO, PLSFXO, PLLNID", new[] { "PLDOCO", "PLDCTO", "PLKCOO", "PLSFXO", "PLLNID" })
    };
}
