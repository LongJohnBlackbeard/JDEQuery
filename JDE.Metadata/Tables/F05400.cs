using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05400 - .
/// </summary>
public class F05400 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFEECD.
        /// </summary>
        public const string PFEECD = "PFEECD";

        /// <summary>
        /// PFCO.
        /// </summary>
        public const string PFCO = "PFCO";

        /// <summary>
        /// PFCCPR.
        /// </summary>
        public const string PFCCPR = "PFCCPR";

        /// <summary>
        /// PFUKID.
        /// </summary>
        public const string PFUKID = "PFUKID";

        /// <summary>
        /// PFSEQ.
        /// </summary>
        public const string PFSEQ = "PFSEQ";

        /// <summary>
        /// PFSSENAB.
        /// </summary>
        public const string PFSSENAB = "PFSSENAB";

        /// <summary>
        /// PFACTPRF.
        /// </summary>
        public const string PFACTPRF = "PFACTPRF";

        /// <summary>
        /// PFSSACTS.
        /// </summary>
        public const string PFSSACTS = "PFSSACTS";

        /// <summary>
        /// PFOBNM.
        /// </summary>
        public const string PFOBNM = "PFOBNM";

        /// <summary>
        /// PFFMNM.
        /// </summary>
        public const string PFFMNM = "PFFMNM";

        /// <summary>
        /// PFVERS.
        /// </summary>
        public const string PFVERS = "PFVERS";

        /// <summary>
        /// PFEAN8.
        /// </summary>
        public const string PFEAN8 = "PFEAN8";

        /// <summary>
        /// PFSSCT00.
        /// </summary>
        public const string PFSSCT00 = "PFSSCT00";

        /// <summary>
        /// PFSSCT01.
        /// </summary>
        public const string PFSSCT01 = "PFSSCT01";

        /// <summary>
        /// PFSSCT02.
        /// </summary>
        public const string PFSSCT02 = "PFSSCT02";

        /// <summary>
        /// PFSSCT03.
        /// </summary>
        public const string PFSSCT03 = "PFSSCT03";

        /// <summary>
        /// PFSSCT04.
        /// </summary>
        public const string PFSSCT04 = "PFSSCT04";

        /// <summary>
        /// PFSSCT05.
        /// </summary>
        public const string PFSSCT05 = "PFSSCT05";

        /// <summary>
        /// PFSSCT06.
        /// </summary>
        public const string PFSSCT06 = "PFSSCT06";

        /// <summary>
        /// PFSSCT07.
        /// </summary>
        public const string PFSSCT07 = "PFSSCT07";

        /// <summary>
        /// PFSSCT08.
        /// </summary>
        public const string PFSSCT08 = "PFSSCT08";

        /// <summary>
        /// PFSSCT09.
        /// </summary>
        public const string PFSSCT09 = "PFSSCT09";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFUPMT.
        /// </summary>
        public const string PFUPMT = "PFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05400";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFEECD", "PFEECD", JdeDataType.String, 6, true, true),
        new JdeField("PFCO", "PFCO", JdeDataType.String, 10, true, true),
        new JdeField("PFCCPR", "PFCCPR", JdeDataType.String, 6, true, true),
        new JdeField("PFUKID", "PFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PFSEQ", "PFSEQ", JdeDataType.Numeric),
        new JdeField("PFSSENAB", "PFSSENAB", JdeDataType.String, 2),
        new JdeField("PFACTPRF", "PFACTPRF", JdeDataType.String, 8),
        new JdeField("PFSSACTS", "PFSSACTS", JdeDataType.String, 20),
        new JdeField("PFOBNM", "PFOBNM", JdeDataType.String, 20),
        new JdeField("PFFMNM", "PFFMNM", JdeDataType.String, 20),
        new JdeField("PFVERS", "PFVERS", JdeDataType.String, 20),
        new JdeField("PFEAN8", "PFEAN8", JdeDataType.Numeric),
        new JdeField("PFSSCT00", "PFSSCT00", JdeDataType.String, 20),
        new JdeField("PFSSCT01", "PFSSCT01", JdeDataType.String, 20),
        new JdeField("PFSSCT02", "PFSSCT02", JdeDataType.String, 20),
        new JdeField("PFSSCT03", "PFSSCT03", JdeDataType.String, 20),
        new JdeField("PFSSCT04", "PFSSCT04", JdeDataType.String, 20),
        new JdeField("PFSSCT05", "PFSSCT05", JdeDataType.String, 20),
        new JdeField("PFSSCT06", "PFSSCT06", JdeDataType.String, 20),
        new JdeField("PFSSCT07", "PFSSCT07", JdeDataType.String, 20),
        new JdeField("PFSSCT08", "PFSSCT08", JdeDataType.String, 20),
        new JdeField("PFSSCT09", "PFSSCT09", JdeDataType.String, 20),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFUPMT", "PFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05400_0", "Primary Key on PFEECD, PFCO, PFCCPR, PFUKID", new[] { "PFEECD", "PFCO", "PFCCPR", "PFUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05400_2", "Index on PFEECD, PFCO, PFCCPR, PFSEQ, PFUKID", new[] { "PFEECD", "PFCO", "PFCCPR", "PFSEQ", "PFUKID" }),
        new JdeIndex("F05400_3", "Index on PFEECD, PFCO, PFCCPR, SYS_NC00028$, PFUKID", new[] { "PFEECD", "PFCO", "PFCCPR", "SYS_NC00028$", "PFUKID" }),
        new JdeIndex("F05400_4", "Index on PFEECD, PFCO, PFCCPR, PFSSACTS", new[] { "PFEECD", "PFCO", "PFCCPR", "PFSSACTS" })
    };
}
