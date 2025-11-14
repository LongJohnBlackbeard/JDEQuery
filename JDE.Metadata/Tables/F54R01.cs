using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R01 - .
/// </summary>
public class F54R01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCMCU.
        /// </summary>
        public const string RCMCU = "RCMCU";

        /// <summary>
        /// RCCO.
        /// </summary>
        public const string RCCO = "RCCO";

        /// <summary>
        /// RC54ROACM.
        /// </summary>
        public const string RC54ROACM = "RC54ROACM";

        /// <summary>
        /// RC54RACM.
        /// </summary>
        public const string RC54RACM = "RC54RACM";

        /// <summary>
        /// RC54RADAM.
        /// </summary>
        public const string RC54RADAM = "RC54RADAM";

        /// <summary>
        /// RC54RBM.
        /// </summary>
        public const string RC54RBM = "RC54RBM";

        /// <summary>
        /// RC54RBDPW.
        /// </summary>
        public const string RC54RBDPW = "RC54RBDPW";

        /// <summary>
        /// RCWDCT.
        /// </summary>
        public const string RCWDCT = "RCWDCT";

        /// <summary>
        /// RC54RRMAG.
        /// </summary>
        public const string RC54RRMAG = "RC54RRMAG";

        /// <summary>
        /// RC54RRMAF.
        /// </summary>
        public const string RC54RRMAF = "RC54RRMAF";

        /// <summary>
        /// RC54RMINRP.
        /// </summary>
        public const string RC54RMINRP = "RC54RMINRP";

        /// <summary>
        /// RC54RMINUM.
        /// </summary>
        public const string RC54RMINUM = "RC54RMINUM";

        /// <summary>
        /// RC54RMAXRP.
        /// </summary>
        public const string RC54RMAXRP = "RC54RMAXRP";

        /// <summary>
        /// RC54RMAXUM.
        /// </summary>
        public const string RC54RMAXUM = "RC54RMAXUM";

        /// <summary>
        /// RC54RRSVA.
        /// </summary>
        public const string RC54RRSVA = "RC54RRSVA";

        /// <summary>
        /// RC54RCRSVA.
        /// </summary>
        public const string RC54RCRSVA = "RC54RCRSVA";

        /// <summary>
        /// RC54RDRSVP.
        /// </summary>
        public const string RC54RDRSVP = "RC54RDRSVP";

        /// <summary>
        /// RC54RDRSVU.
        /// </summary>
        public const string RC54RDRSVU = "RC54RDRSVU";

        /// <summary>
        /// RC54RATA.
        /// </summary>
        public const string RC54RATA = "RC54RATA";

        /// <summary>
        /// RC54RICTE.
        /// </summary>
        public const string RC54RICTE = "RC54RICTE";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCMKEY.
        /// </summary>
        public const string RCMKEY = "RCMKEY";

        /// <summary>
        /// RCURCD.
        /// </summary>
        public const string RCURCD = "RCURCD";

        /// <summary>
        /// RCURDT.
        /// </summary>
        public const string RCURDT = "RCURDT";

        /// <summary>
        /// RCURAT.
        /// </summary>
        public const string RCURAT = "RCURAT";

        /// <summary>
        /// RCURAB.
        /// </summary>
        public const string RCURAB = "RCURAB";

        /// <summary>
        /// RCURRF.
        /// </summary>
        public const string RCURRF = "RCURRF";

        /// <summary>
        /// RCENTJ.
        /// </summary>
        public const string RCENTJ = "RCENTJ";

        /// <summary>
        /// RCTORG.
        /// </summary>
        public const string RCTORG = "RCTORG";

        /// <summary>
        /// RCTENT.
        /// </summary>
        public const string RCTENT = "RCTENT";

        /// <summary>
        /// RC54RSOS1.
        /// </summary>
        public const string RC54RSOS1 = "RC54RSOS1";

        /// <summary>
        /// RC54RSOS2.
        /// </summary>
        public const string RC54RSOS2 = "RC54RSOS2";

        /// <summary>
        /// RC54RSOS3.
        /// </summary>
        public const string RC54RSOS3 = "RC54RSOS3";

        /// <summary>
        /// RC54RPOS1.
        /// </summary>
        public const string RC54RPOS1 = "RC54RPOS1";

        /// <summary>
        /// RC54RPOS2.
        /// </summary>
        public const string RC54RPOS2 = "RC54RPOS2";

        /// <summary>
        /// RC54RPOS3.
        /// </summary>
        public const string RC54RPOS3 = "RC54RPOS3";

        /// <summary>
        /// RC54RWOS1.
        /// </summary>
        public const string RC54RWOS1 = "RC54RWOS1";

        /// <summary>
        /// RC54RWOS2.
        /// </summary>
        public const string RC54RWOS2 = "RC54RWOS2";

        /// <summary>
        /// RC54RWOS3.
        /// </summary>
        public const string RC54RWOS3 = "RC54RWOS3";
    }

    /// <inheritdoc />
    public override string TableName => "F54R01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCMCU", "RCMCU", JdeDataType.String, 24, true, true),
        new JdeField("RCCO", "RCCO", JdeDataType.String, 10, true, true),
        new JdeField("RC54ROACM", "RC54ROACM", JdeDataType.String, 4),
        new JdeField("RC54RACM", "RC54RACM", JdeDataType.String, 4),
        new JdeField("RC54RADAM", "RC54RADAM", JdeDataType.String, 2),
        new JdeField("RC54RBM", "RC54RBM", JdeDataType.String, 2),
        new JdeField("RC54RBDPW", "RC54RBDPW", JdeDataType.Numeric),
        new JdeField("RCWDCT", "RCWDCT", JdeDataType.String, 20),
        new JdeField("RC54RRMAG", "RC54RRMAG", JdeDataType.Numeric),
        new JdeField("RC54RRMAF", "RC54RRMAF", JdeDataType.Numeric),
        new JdeField("RC54RMINRP", "RC54RMINRP", JdeDataType.Numeric),
        new JdeField("RC54RMINUM", "RC54RMINUM", JdeDataType.String, 2),
        new JdeField("RC54RMAXRP", "RC54RMAXRP", JdeDataType.Numeric),
        new JdeField("RC54RMAXUM", "RC54RMAXUM", JdeDataType.String, 2),
        new JdeField("RC54RRSVA", "RC54RRSVA", JdeDataType.String, 2),
        new JdeField("RC54RCRSVA", "RC54RCRSVA", JdeDataType.String, 2),
        new JdeField("RC54RDRSVP", "RC54RDRSVP", JdeDataType.Numeric),
        new JdeField("RC54RDRSVU", "RC54RDRSVU", JdeDataType.String, 2),
        new JdeField("RC54RATA", "RC54RATA", JdeDataType.String, 2),
        new JdeField("RC54RICTE", "RC54RICTE", JdeDataType.String, 2),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCMKEY", "RCMKEY", JdeDataType.String, 30),
        new JdeField("RCURCD", "RCURCD", JdeDataType.String, 4),
        new JdeField("RCURDT", "RCURDT", JdeDataType.Numeric),
        new JdeField("RCURAT", "RCURAT", JdeDataType.Numeric),
        new JdeField("RCURAB", "RCURAB", JdeDataType.Numeric),
        new JdeField("RCURRF", "RCURRF", JdeDataType.String, 30),
        new JdeField("RCENTJ", "RCENTJ", JdeDataType.Numeric),
        new JdeField("RCTORG", "RCTORG", JdeDataType.String, 20),
        new JdeField("RCTENT", "RCTENT", JdeDataType.Numeric),
        new JdeField("RC54RSOS1", "RC54RSOS1", JdeDataType.String, 6),
        new JdeField("RC54RSOS2", "RC54RSOS2", JdeDataType.String, 6),
        new JdeField("RC54RSOS3", "RC54RSOS3", JdeDataType.String, 6),
        new JdeField("RC54RPOS1", "RC54RPOS1", JdeDataType.String, 6),
        new JdeField("RC54RPOS2", "RC54RPOS2", JdeDataType.String, 6),
        new JdeField("RC54RPOS3", "RC54RPOS3", JdeDataType.String, 6),
        new JdeField("RC54RWOS1", "RC54RWOS1", JdeDataType.String, 4),
        new JdeField("RC54RWOS2", "RC54RWOS2", JdeDataType.String, 4),
        new JdeField("RC54RWOS3", "RC54RWOS3", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R01_0", "Primary Key on RCCO, RCMCU", new[] { "RCCO", "RCMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R01_2", "Index on RCCO", new[] { "RCCO" })
    };
}
