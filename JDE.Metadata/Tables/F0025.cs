using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0025 - .
/// </summary>
public class F0025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LHLT.
        /// </summary>
        public const string LHLT = "LHLT";

        /// <summary>
        /// LHDL01.
        /// </summary>
        public const string LHDL01 = "LHDL01";

        /// <summary>
        /// LHULT.
        /// </summary>
        public const string LHULT = "LHULT";

        /// <summary>
        /// LHFRE.
        /// </summary>
        public const string LHFRE = "LHFRE";

        /// <summary>
        /// LHFLRB.
        /// </summary>
        public const string LHFLRB = "LHFLRB";

        /// <summary>
        /// LHFISL.
        /// </summary>
        public const string LHFISL = "LHFISL";

        /// <summary>
        /// LHFROB.
        /// </summary>
        public const string LHFROB = "LHFROB";

        /// <summary>
        /// LHFDNS.
        /// </summary>
        public const string LHFDNS = "LHFDNS";

        /// <summary>
        /// LHFRL.
        /// </summary>
        public const string LHFRL = "LHFRL";

        /// <summary>
        /// LHFDBU.
        /// </summary>
        public const string LHFDBU = "LHFDBU";

        /// <summary>
        /// LHCRCX.
        /// </summary>
        public const string LHCRCX = "LHCRCX";

        /// <summary>
        /// LHLTCF.
        /// </summary>
        public const string LHLTCF = "LHLTCF";

        /// <summary>
        /// LHGLGA.
        /// </summary>
        public const string LHGLGA = "LHGLGA";

        /// <summary>
        /// LHRNDR.
        /// </summary>
        public const string LHRNDR = "LHRNDR";

        /// <summary>
        /// LHODPN.
        /// </summary>
        public const string LHODPN = "LHODPN";

        /// <summary>
        /// LHNNPO.
        /// </summary>
        public const string LHNNPO = "LHNNPO";

        /// <summary>
        /// LHCH1.
        /// </summary>
        public const string LHCH1 = "LHCH1";

        /// <summary>
        /// LHCH2.
        /// </summary>
        public const string LHCH2 = "LHCH2";

        /// <summary>
        /// LHFBL.
        /// </summary>
        public const string LHFBL = "LHFBL";

        /// <summary>
        /// LHFJCS.
        /// </summary>
        public const string LHFJCS = "LHFJCS";

        /// <summary>
        /// LHFFU1.
        /// </summary>
        public const string LHFFU1 = "LHFFU1";

        /// <summary>
        /// LHFFU2.
        /// </summary>
        public const string LHFFU2 = "LHFFU2";

        /// <summary>
        /// LHUSER.
        /// </summary>
        public const string LHUSER = "LHUSER";

        /// <summary>
        /// LHPID.
        /// </summary>
        public const string LHPID = "LHPID";

        /// <summary>
        /// LHUPMJ.
        /// </summary>
        public const string LHUPMJ = "LHUPMJ";

        /// <summary>
        /// LHJOBN.
        /// </summary>
        public const string LHJOBN = "LHJOBN";

        /// <summary>
        /// LHUPMT.
        /// </summary>
        public const string LHUPMT = "LHUPMT";

        /// <summary>
        /// LHFCJE.
        /// </summary>
        public const string LHFCJE = "LHFCJE";
    }

    /// <inheritdoc />
    public override string TableName => "F0025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LHLT", "LHLT", JdeDataType.String, 4, true, true),
        new JdeField("LHDL01", "LHDL01", JdeDataType.String, 60),
        new JdeField("LHULT", "LHULT", JdeDataType.String, 4),
        new JdeField("LHFRE", "LHFRE", JdeDataType.String, 2),
        new JdeField("LHFLRB", "LHFLRB", JdeDataType.String, 2),
        new JdeField("LHFISL", "LHFISL", JdeDataType.String, 2),
        new JdeField("LHFROB", "LHFROB", JdeDataType.String, 2),
        new JdeField("LHFDNS", "LHFDNS", JdeDataType.String, 2),
        new JdeField("LHFRL", "LHFRL", JdeDataType.String, 2),
        new JdeField("LHFDBU", "LHFDBU", JdeDataType.String, 2),
        new JdeField("LHCRCX", "LHCRCX", JdeDataType.String, 6),
        new JdeField("LHLTCF", "LHLTCF", JdeDataType.String, 4),
        new JdeField("LHGLGA", "LHGLGA", JdeDataType.String, 2),
        new JdeField("LHRNDR", "LHRNDR", JdeDataType.String, 2),
        new JdeField("LHODPN", "LHODPN", JdeDataType.String, 2),
        new JdeField("LHNNPO", "LHNNPO", JdeDataType.String, 4),
        new JdeField("LHCH1", "LHCH1", JdeDataType.String, 40),
        new JdeField("LHCH2", "LHCH2", JdeDataType.String, 40),
        new JdeField("LHFBL", "LHFBL", JdeDataType.String, 2),
        new JdeField("LHFJCS", "LHFJCS", JdeDataType.String, 2),
        new JdeField("LHFFU1", "LHFFU1", JdeDataType.String, 2),
        new JdeField("LHFFU2", "LHFFU2", JdeDataType.String, 2),
        new JdeField("LHUSER", "LHUSER", JdeDataType.String, 20),
        new JdeField("LHPID", "LHPID", JdeDataType.String, 20),
        new JdeField("LHUPMJ", "LHUPMJ", JdeDataType.Numeric),
        new JdeField("LHJOBN", "LHJOBN", JdeDataType.String, 20),
        new JdeField("LHUPMT", "LHUPMT", JdeDataType.Numeric),
        new JdeField("LHFCJE", "LHFCJE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0025_0", "Primary Key on LHLT", new[] { "LHLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0025_2", "Index on LHULT", new[] { "LHULT" })
    };
}
