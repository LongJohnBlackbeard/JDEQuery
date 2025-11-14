using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77200 - .
/// </summary>
public class F77200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J5YEID.
        /// </summary>
        public const string J5YEID = "J5YEID";

        /// <summary>
        /// J5TAXYR.
        /// </summary>
        public const string J5TAXYR = "J5TAXYR";

        /// <summary>
        /// J5AN8.
        /// </summary>
        public const string J5AN8 = "J5AN8";

        /// <summary>
        /// J5FORMSID.
        /// </summary>
        public const string J5FORMSID = "J5FORMSID";

        /// <summary>
        /// J5FORMD.
        /// </summary>
        public const string J5FORMD = "J5FORMD";

        /// <summary>
        /// J5CO.
        /// </summary>
        public const string J5CO = "J5CO";

        /// <summary>
        /// J5AMNDT.
        /// </summary>
        public const string J5AMNDT = "J5AMNDT";

        /// <summary>
        /// J5TARA.
        /// </summary>
        public const string J5TARA = "J5TARA";

        /// <summary>
        /// J5TAXX.
        /// </summary>
        public const string J5TAXX = "J5TAXX";

        /// <summary>
        /// J5SSN.
        /// </summary>
        public const string J5SSN = "J5SSN";

        /// <summary>
        /// J5ALPH.
        /// </summary>
        public const string J5ALPH = "J5ALPH";

        /// <summary>
        /// J5HMCU.
        /// </summary>
        public const string J5HMCU = "J5HMCU";

        /// <summary>
        /// J5PFCNO.
        /// </summary>
        public const string J5PFCNO = "J5PFCNO";

        /// <summary>
        /// J5SFCNO.
        /// </summary>
        public const string J5SFCNO = "J5SFCNO";

        /// <summary>
        /// J5T4PE.
        /// </summary>
        public const string J5T4PE = "J5T4PE";

        /// <summary>
        /// J5FDWG.
        /// </summary>
        public const string J5FDWG = "J5FDWG";

        /// <summary>
        /// J5AFDWG.
        /// </summary>
        public const string J5AFDWG = "J5AFDWG";

        /// <summary>
        /// J5FDTX.
        /// </summary>
        public const string J5FDTX = "J5FDTX";

        /// <summary>
        /// J5AFDTX.
        /// </summary>
        public const string J5AFDTX = "J5AFDTX";

        /// <summary>
        /// J5PRTXW.
        /// </summary>
        public const string J5PRTXW = "J5PRTXW";

        /// <summary>
        /// J5APRTXW.
        /// </summary>
        public const string J5APRTXW = "J5APRTXW";

        /// <summary>
        /// J5PRITX.
        /// </summary>
        public const string J5PRITX = "J5PRITX";

        /// <summary>
        /// J5APRITX.
        /// </summary>
        public const string J5APRITX = "J5APRITX";

        /// <summary>
        /// J5EIER.
        /// </summary>
        public const string J5EIER = "J5EIER";

        /// <summary>
        /// J5AEIER.
        /// </summary>
        public const string J5AEIER = "J5AEIER";

        /// <summary>
        /// J5EIP.
        /// </summary>
        public const string J5EIP = "J5EIP";

        /// <summary>
        /// J5AEIP.
        /// </summary>
        public const string J5AEIP = "J5AEIP";

        /// <summary>
        /// J5EIPR.
        /// </summary>
        public const string J5EIPR = "J5EIPR";

        /// <summary>
        /// J5CPPE.
        /// </summary>
        public const string J5CPPE = "J5CPPE";

        /// <summary>
        /// J5ACPPE.
        /// </summary>
        public const string J5ACPPE = "J5ACPPE";

        /// <summary>
        /// J5CPP.
        /// </summary>
        public const string J5CPP = "J5CPP";

        /// <summary>
        /// J5ACPP.
        /// </summary>
        public const string J5ACPP = "J5ACPP";

        /// <summary>
        /// J5CPER.
        /// </summary>
        public const string J5CPER = "J5CPER";

        /// <summary>
        /// J5QPP.
        /// </summary>
        public const string J5QPP = "J5QPP";

        /// <summary>
        /// J5AQPP.
        /// </summary>
        public const string J5AQPP = "J5AQPP";

        /// <summary>
        /// J5GI1.
        /// </summary>
        public const string J5GI1 = "J5GI1";

        /// <summary>
        /// J5AGI1.
        /// </summary>
        public const string J5AGI1 = "J5AGI1";

        /// <summary>
        /// J5TXW1.
        /// </summary>
        public const string J5TXW1 = "J5TXW1";

        /// <summary>
        /// J5ATXW1.
        /// </summary>
        public const string J5ATXW1 = "J5ATXW1";

        /// <summary>
        /// J5GI2.
        /// </summary>
        public const string J5GI2 = "J5GI2";

        /// <summary>
        /// J5AGI2.
        /// </summary>
        public const string J5AGI2 = "J5AGI2";

        /// <summary>
        /// J5TXW2.
        /// </summary>
        public const string J5TXW2 = "J5TXW2";

        /// <summary>
        /// J5ATXW2.
        /// </summary>
        public const string J5ATXW2 = "J5ATXW2";

        /// <summary>
        /// J5PPIP.
        /// </summary>
        public const string J5PPIP = "J5PPIP";

        /// <summary>
        /// J5APPIP.
        /// </summary>
        public const string J5APPIP = "J5APPIP";

        /// <summary>
        /// J5PPIE.
        /// </summary>
        public const string J5PPIE = "J5PPIE";

        /// <summary>
        /// J5APPIE.
        /// </summary>
        public const string J5APPIE = "J5APPIE";

        /// <summary>
        /// J5QPER.
        /// </summary>
        public const string J5QPER = "J5QPER";

        /// <summary>
        /// J5T4EC.
        /// </summary>
        public const string J5T4EC = "J5T4EC";

        /// <summary>
        /// J5ECPP.
        /// </summary>
        public const string J5ECPP = "J5ECPP";

        /// <summary>
        /// J5EPP.
        /// </summary>
        public const string J5EPP = "J5EPP";

        /// <summary>
        /// J5NRCT.
        /// </summary>
        public const string J5NRCT = "J5NRCT";

        /// <summary>
        /// J5CCPR.
        /// </summary>
        public const string J5CCPR = "J5CCPR";

        /// <summary>
        /// J5EEI.
        /// </summary>
        public const string J5EEI = "J5EEI";

        /// <summary>
        /// J5SSIN.
        /// </summary>
        public const string J5SSIN = "J5SSIN";

        /// <summary>
        /// J5SALPH.
        /// </summary>
        public const string J5SALPH = "J5SALPH";

        /// <summary>
        /// J5R2PR.
        /// </summary>
        public const string J5R2PR = "J5R2PR";

        /// <summary>
        /// J5ICC1.
        /// </summary>
        public const string J5ICC1 = "J5ICC1";

        /// <summary>
        /// J5CC1.
        /// </summary>
        public const string J5CC1 = "J5CC1";

        /// <summary>
        /// J5EXC1.
        /// </summary>
        public const string J5EXC1 = "J5EXC1";

        /// <summary>
        /// J5ICC2.
        /// </summary>
        public const string J5ICC2 = "J5ICC2";

        /// <summary>
        /// J5CC2.
        /// </summary>
        public const string J5CC2 = "J5CC2";

        /// <summary>
        /// J5EXC2.
        /// </summary>
        public const string J5EXC2 = "J5EXC2";

        /// <summary>
        /// J5ARCS.
        /// </summary>
        public const string J5ARCS = "J5ARCS";

        /// <summary>
        /// J5UPMJ.
        /// </summary>
        public const string J5UPMJ = "J5UPMJ";

        /// <summary>
        /// J5UPMT.
        /// </summary>
        public const string J5UPMT = "J5UPMT";

        /// <summary>
        /// J5PID.
        /// </summary>
        public const string J5PID = "J5PID";

        /// <summary>
        /// J5JOBN.
        /// </summary>
        public const string J5JOBN = "J5JOBN";

        /// <summary>
        /// J5USER.
        /// </summary>
        public const string J5USER = "J5USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J5YEID", "J5YEID", JdeDataType.String, 20, true, true),
        new JdeField("J5TAXYR", "J5TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J5AN8", "J5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J5FORMSID", "J5FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J5FORMD", "J5FORMD", JdeDataType.String, 80),
        new JdeField("J5CO", "J5CO", JdeDataType.String, 10, true, true),
        new JdeField("J5AMNDT", "J5AMNDT", JdeDataType.String, 2, true, true),
        new JdeField("J5TARA", "J5TARA", JdeDataType.String, 20, true, true),
        new JdeField("J5TAXX", "J5TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J5SSN", "J5SSN", JdeDataType.String, 40),
        new JdeField("J5ALPH", "J5ALPH", JdeDataType.String, 80),
        new JdeField("J5HMCU", "J5HMCU", JdeDataType.String, 24),
        new JdeField("J5PFCNO", "J5PFCNO", JdeDataType.Numeric),
        new JdeField("J5SFCNO", "J5SFCNO", JdeDataType.Numeric),
        new JdeField("J5T4PE", "J5T4PE", JdeDataType.String, 4),
        new JdeField("J5FDWG", "J5FDWG", JdeDataType.Numeric),
        new JdeField("J5AFDWG", "J5AFDWG", JdeDataType.Numeric),
        new JdeField("J5FDTX", "J5FDTX", JdeDataType.Numeric),
        new JdeField("J5AFDTX", "J5AFDTX", JdeDataType.Numeric),
        new JdeField("J5PRTXW", "J5PRTXW", JdeDataType.Numeric),
        new JdeField("J5APRTXW", "J5APRTXW", JdeDataType.Numeric),
        new JdeField("J5PRITX", "J5PRITX", JdeDataType.Numeric),
        new JdeField("J5APRITX", "J5APRITX", JdeDataType.Numeric),
        new JdeField("J5EIER", "J5EIER", JdeDataType.Numeric),
        new JdeField("J5AEIER", "J5AEIER", JdeDataType.Numeric),
        new JdeField("J5EIP", "J5EIP", JdeDataType.Numeric),
        new JdeField("J5AEIP", "J5AEIP", JdeDataType.Numeric),
        new JdeField("J5EIPR", "J5EIPR", JdeDataType.Numeric),
        new JdeField("J5CPPE", "J5CPPE", JdeDataType.Numeric),
        new JdeField("J5ACPPE", "J5ACPPE", JdeDataType.Numeric),
        new JdeField("J5CPP", "J5CPP", JdeDataType.Numeric),
        new JdeField("J5ACPP", "J5ACPP", JdeDataType.Numeric),
        new JdeField("J5CPER", "J5CPER", JdeDataType.Numeric),
        new JdeField("J5QPP", "J5QPP", JdeDataType.Numeric),
        new JdeField("J5AQPP", "J5AQPP", JdeDataType.Numeric),
        new JdeField("J5GI1", "J5GI1", JdeDataType.Numeric),
        new JdeField("J5AGI1", "J5AGI1", JdeDataType.Numeric),
        new JdeField("J5TXW1", "J5TXW1", JdeDataType.Numeric),
        new JdeField("J5ATXW1", "J5ATXW1", JdeDataType.Numeric),
        new JdeField("J5GI2", "J5GI2", JdeDataType.Numeric),
        new JdeField("J5AGI2", "J5AGI2", JdeDataType.Numeric),
        new JdeField("J5TXW2", "J5TXW2", JdeDataType.Numeric),
        new JdeField("J5ATXW2", "J5ATXW2", JdeDataType.Numeric),
        new JdeField("J5PPIP", "J5PPIP", JdeDataType.Numeric),
        new JdeField("J5APPIP", "J5APPIP", JdeDataType.Numeric),
        new JdeField("J5PPIE", "J5PPIE", JdeDataType.Numeric),
        new JdeField("J5APPIE", "J5APPIE", JdeDataType.Numeric),
        new JdeField("J5QPER", "J5QPER", JdeDataType.Numeric),
        new JdeField("J5T4EC", "J5T4EC", JdeDataType.String, 4),
        new JdeField("J5ECPP", "J5ECPP", JdeDataType.String, 2),
        new JdeField("J5EPP", "J5EPP", JdeDataType.Numeric),
        new JdeField("J5NRCT", "J5NRCT", JdeDataType.String, 2),
        new JdeField("J5CCPR", "J5CCPR", JdeDataType.String, 6),
        new JdeField("J5EEI", "J5EEI", JdeDataType.String, 2),
        new JdeField("J5SSIN", "J5SSIN", JdeDataType.String, 40),
        new JdeField("J5SALPH", "J5SALPH", JdeDataType.String, 80),
        new JdeField("J5R2PR", "J5R2PR", JdeDataType.String, 20),
        new JdeField("J5ICC1", "J5ICC1", JdeDataType.String, 20),
        new JdeField("J5CC1", "J5CC1", JdeDataType.String, 6),
        new JdeField("J5EXC1", "J5EXC1", JdeDataType.String, 6),
        new JdeField("J5ICC2", "J5ICC2", JdeDataType.String, 20),
        new JdeField("J5CC2", "J5CC2", JdeDataType.String, 6),
        new JdeField("J5EXC2", "J5EXC2", JdeDataType.String, 6),
        new JdeField("J5ARCS", "J5ARCS", JdeDataType.String, 2),
        new JdeField("J5UPMJ", "J5UPMJ", JdeDataType.Numeric),
        new JdeField("J5UPMT", "J5UPMT", JdeDataType.Numeric),
        new JdeField("J5PID", "J5PID", JdeDataType.String, 20),
        new JdeField("J5JOBN", "J5JOBN", JdeDataType.String, 20),
        new JdeField("J5USER", "J5USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77200_0", "Primary Key on J5YEID, J5TAXYR, J5AN8, J5FORMSID, J5CO, J5AMNDT, J5TAXX, J5TARA", new[] { "J5YEID", "J5TAXYR", "J5AN8", "J5FORMSID", "J5CO", "J5AMNDT", "J5TAXX", "J5TARA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77200_2", "Index on J5FORMSID, SYS_NC00070$", new[] { "J5FORMSID", "SYS_NC00070$" }),
        new JdeIndex("F77200_3", "Index on J5FORMSID, SYS_NC00071$", new[] { "J5FORMSID", "SYS_NC00071$" }),
        new JdeIndex("F77200_4", "Index on J5YEID, J5TAXYR, J5FORMSID", new[] { "J5YEID", "J5TAXYR", "J5FORMSID" }),
        new JdeIndex("F77200_5", "Index on J5YEID, J5TAXYR", new[] { "J5YEID", "J5TAXYR" }),
        new JdeIndex("F77200_6", "Index on J5TAXYR, J5FORMSID, SYS_NC00070$", new[] { "J5TAXYR", "J5FORMSID", "SYS_NC00070$" }),
        new JdeIndex("F77200_7", "Index on J5TAXYR, J5FORMSID, SYS_NC00071$", new[] { "J5TAXYR", "J5FORMSID", "SYS_NC00071$" })
    };
}
